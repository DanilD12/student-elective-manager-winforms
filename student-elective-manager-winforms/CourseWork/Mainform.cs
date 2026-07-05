using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        private List<Student> students = new List<Student>();
        private List<Student> currentView = new List<Student>();

        public MainForm()
        {
            InitializeComponent();
            InitializeGrid();
            InitializeControls();
            LoadData();
        }

        private void InitializeGrid()
        {
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.Columns.Clear();

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ф.И.О.",
                DataPropertyName = "FullName",
                Width = 220
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Группа",
                DataPropertyName = "GroupNumber",
                Width = 90
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ср. балл",
                DataPropertyName = "AverageGrade",
                Width = 80
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Выбранные дисциплины",
                DataPropertyName = "SubjectsText",
                Width = 320
            });

            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.AllowUserToAddRows = false;
        }

        private void InitializeControls()
        {
            cmbSearchSubject.Items.Clear();
            cmbSearchSubject.Items.Add("Все");
            cmbSearchSubject.Items.Add("Математика");
            cmbSearchSubject.Items.Add("Физика");
            cmbSearchSubject.Items.Add("Программирование");
            cmbSearchSubject.Items.Add("Английский язык");
            cmbSearchSubject.Items.Add("Базы данных");
            cmbSearchSubject.SelectedIndex = 0;

            cmbSort.Items.Clear();
            cmbSort.Items.Add("Ф.И.О.");
            cmbSort.Items.Add("Группа");
            cmbSort.Items.Add("Средний балл");
            cmbSort.Items.Add("Количество дисциплин");
            cmbSort.SelectedIndex = 0;
        }

        private void LoadData()
        {
            students = StudentStorage.LoadStudents();
            currentView = students.ToList();
            BindGrid(currentView);
        }

        private void BindGrid(List<Student> data)
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = data;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            rtbOutput.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                students.Add(form.StudentData);
                StudentStorage.SaveStudents(students);
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования.");
                return;
            }

            Student selectedStudent = (Student)dgvStudents.CurrentRow.DataBoundItem;
            AddEditForm form = new AddEditForm(selectedStudent, true);

            if (form.ShowDialog() == DialogResult.OK)
            {
                StudentStorage.SaveStudents(students);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }

            Student selectedStudent = (Student)dgvStudents.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show(
                "Удалить выбранную запись?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                students.Remove(selectedStudent);
                StudentStorage.SaveStudents(students);
                LoadData();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> query = students;

            string name = txtSearchName.Text.Trim().ToLower();
            string group = txtSearchGroup.Text.Trim().ToLower();
            string subject = cmbSearchSubject.SelectedItem != null ? cmbSearchSubject.SelectedItem.ToString() : "Все";
            string minGradeText = txtMinGrade.Text.Trim();

            if (!string.IsNullOrWhiteSpace(name))
                query = query.Where(s => s.FullName.ToLower().Contains(name));

            if (!string.IsNullOrWhiteSpace(group))
                query = query.Where(s => s.GroupNumber.ToLower().Contains(group));

            if (!string.IsNullOrWhiteSpace(subject) && subject != "Все")
                query = query.Where(s => s.HasSubject(subject));

            if (!string.IsNullOrWhiteSpace(minGradeText))
            {
                double minGrade;
                if (double.TryParse(minGradeText.Replace(',', '.'),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out minGrade))
                {
                    query = query.Where(s => s.AverageGrade >= minGrade);
                }
                else
                {
                    MessageBox.Show("Минимальный балл введён неверно.");
                    return;
                }
            }

            currentView = query.ToList();
            BindGrid(currentView);

            rtbOutput.Text =
                "Результат фильтрации:\n" +
                $"Найдено записей: {currentView.Count}\n";
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
            txtSearchGroup.Clear();
            txtMinGrade.Clear();
            cmbSearchSubject.SelectedIndex = 0;

            currentView = students.ToList();
            BindGrid(currentView);
            rtbOutput.Clear();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cmbSort.SelectedItem == null)
                return;

            string sortBy = cmbSort.SelectedItem.ToString();

            switch (sortBy)
            {
                case "Ф.И.О.":
                    currentView = currentView.OrderBy(s => s.FullName).ToList();
                    break;
                case "Группа":
                    currentView = currentView.OrderBy(s => s.GroupNumber).ToList();
                    break;
                case "Средний балл":
                    currentView = currentView.OrderByDescending(s => s.AverageGrade).ToList();
                    break;
                case "Количество дисциплин":
                    currentView = currentView.OrderByDescending(s => s.SubjectsCount).ToList();
                    break;
            }

            BindGrid(currentView);
            rtbOutput.Text = $"Выполнена сортировка по полю: {sortBy}";
        }

        private void btnIndividualTask_Click(object sender, EventArgs e)
        {
            string subject = cmbSearchSubject.SelectedItem != null ? cmbSearchSubject.SelectedItem.ToString() : "Все";

            if (subject == "Все")
            {
                MessageBox.Show("Для индивидуального задания выберите конкретную дисциплину.");
                return;
            }

            List<Student> interested = students
                .Where(s => s.HasSubject(subject))
                .OrderByDescending(s => s.AverageGrade)
                .ToList();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Индивидуальное задание по дисциплине: {subject}");
            sb.AppendLine($"Общее количество желающих: {interested.Count}");
            sb.AppendLine();

            if (interested.Count > 15)
            {
                sb.AppendLine("Количество желающих больше 15. Отобраны 15 студентов с наивысшим баллом:");
                sb.AppendLine();

                var top15 = interested.Take(15).ToList();
                for (int i = 0; i < top15.Count; i++)
                {
                    sb.AppendLine($"{i + 1}. {top15[i].FullName} | {top15[i].GroupNumber} | {top15[i].AverageGrade:F2}");
                }
            }
            else
            {
                sb.AppendLine("Список студентов:");
                sb.AppendLine();

                for (int i = 0; i < interested.Count; i++)
                {
                    sb.AppendLine($"{i + 1}. {interested[i].FullName} | {interested[i].GroupNumber} | {interested[i].AverageGrade:F2}");
                }
            }

            sb.AppendLine();
            sb.AppendLine("Популярность дисциплин:");

            var popularity = new List<Tuple<string, int>>
            {
                Tuple.Create("Математика", students.Count(s => s.Math)),
                Tuple.Create("Физика", students.Count(s => s.Physics)),
                Tuple.Create("Программирование", students.Count(s => s.Programming)),
                Tuple.Create("Английский язык", students.Count(s => s.English)),
                Tuple.Create("Базы данных", students.Count(s => s.Databases))
            }
            .OrderByDescending(x => x.Item2)
            .ToList();

            for (int i = 0; i < popularity.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {popularity[i].Item1} — {popularity[i].Item2}");
            }

            rtbOutput.Text = sb.ToString();
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbOutput.Text))
            {
                MessageBox.Show("Нет данных для сохранения отчета.");
                return;
            }

            string reportsDir = "reports";
            Directory.CreateDirectory(reportsDir);

            string fileName = $"report_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string path = Path.Combine(reportsDir, fileName);

            File.WriteAllText(path, rtbOutput.Text, Encoding.UTF8);
            MessageBox.Show("Отчет сохранен:\n" + path);
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}