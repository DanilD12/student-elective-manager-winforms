using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddEditForm : Form
    {
        public Student StudentData { get; private set; }

        private bool isEditMode = false;
        private Student originalStudent;

        public AddEditForm()
        {
            InitializeComponent();
            SetupForm();
            isEditMode = false;
            StudentData = new Student();
        }

        public AddEditForm(Student student, bool editMode)
        {
            InitializeComponent();
            SetupForm();

            isEditMode = editMode;
            originalStudent = student;
            StudentData = student;

            FillFieldsFromStudent(student);

            if (isEditMode)
            {
                this.Text = "Редактирование записи";
                cmbEditField.SelectedIndex = 0;
                ApplyEditMode();
            }
        }

        private void SetupForm()
        {
            cmbEditField.Items.Clear();
            cmbEditField.Items.Add("Все поля");
            cmbEditField.Items.Add("Ф.И.О.");
            cmbEditField.Items.Add("Группа");
            cmbEditField.Items.Add("Средний балл");
            cmbEditField.Items.Add("Дисциплины");
            cmbEditField.SelectedIndex = 0;

            this.Text = "Добавление записи";
        }

        private void FillFieldsFromStudent(Student student)
        {
            txtFullName.Text = student.FullName;
            txtGroup.Text = student.GroupNumber;
            txtAverageGrade.Text = student.AverageGrade.ToString("0.00");

            chkMath.Checked = student.Math;
            chkPhysics.Checked = student.Physics;
            chkProgramming.Checked = student.Programming;
            chkEnglish.Checked = student.English;
            chkDatabases.Checked = student.Databases;
        }

        private void ApplyEditMode()
        {
            bool editAll = cmbEditField.SelectedIndex == 0;
            string selected = cmbEditField.SelectedItem.ToString();

            txtFullName.Enabled = editAll || selected == "Ф.И.О.";
            txtGroup.Enabled = editAll || selected == "Группа";
            txtAverageGrade.Enabled = editAll || selected == "Средний балл";

            bool subjectsEnabled = editAll || selected == "Дисциплины";
            chkMath.Enabled = subjectsEnabled;
            chkPhysics.Enabled = subjectsEnabled;
            chkProgramming.Enabled = subjectsEnabled;
            chkEnglish.Enabled = subjectsEnabled;
            chkDatabases.Enabled = subjectsEnabled;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            if (!isEditMode)
            {
                StudentData = new Student();
            }

            bool editAll = !isEditMode || cmbEditField.SelectedIndex == 0;
            string selected = cmbEditField.SelectedItem.ToString();

            if (editAll || selected == "Ф.И.О.")
                StudentData.FullName = txtFullName.Text.Trim();

            if (editAll || selected == "Группа")
                StudentData.GroupNumber = txtGroup.Text.Trim();

            if (editAll || selected == "Средний балл")
                StudentData.AverageGrade = double.Parse(
                    txtAverageGrade.Text.Replace(',', '.'),
                    System.Globalization.CultureInfo.InvariantCulture);

            if (editAll || selected == "Дисциплины")
            {
                StudentData.Math = chkMath.Checked;
                StudentData.Physics = chkPhysics.Checked;
                StudentData.Programming = chkProgramming.Checked;
                StudentData.English = chkEnglish.Checked;
                StudentData.Databases = chkDatabases.Checked;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidateInput()
        {
            bool editAll = !isEditMode || cmbEditField.SelectedIndex == 0;
            string selected = cmbEditField.SelectedItem.ToString();

            if (editAll || selected == "Ф.И.О.")
            {
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Введите Ф.И.О.");
                    return false;
                }
            }

            if (editAll || selected == "Группа")
            {
                if (string.IsNullOrWhiteSpace(txtGroup.Text))
                {
                    MessageBox.Show("Введите группу.");
                    return false;
                }
            }

            if (editAll || selected == "Средний балл")
            {
                double grade;
                if (!double.TryParse(
                    txtAverageGrade.Text.Replace(',', '.'),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out grade))
                {
                    MessageBox.Show("Средний балл введён неверно.");
                    return false;
                }

                if (grade < 0 || grade > 5)
                {
                    MessageBox.Show("Средний балл должен быть от 0 до 5.");
                    return false;
                }
            }

            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbEditField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isEditMode)
                ApplyEditMode();
        }
    }
}