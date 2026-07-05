namespace CourseWork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchGroup = new System.Windows.Forms.TextBox();
            this.txtMinGrade = new System.Windows.Forms.TextBox();
            this.cmbSearchSubject = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnIndividualTask = new System.Windows.Forms.Button();
            this.btnSaveReport = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(12, 2);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(594, 446);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(368, 454);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(238, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(253, 454);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 27);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 454);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 27);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(138, 454);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 27);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(782, 455);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(257, 24);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выйти из учетной записи";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(612, 22);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(168, 20);
            this.txtSearchName.TabIndex = 6;
            // 
            // txtSearchGroup
            // 
            this.txtSearchGroup.Location = new System.Drawing.Point(612, 59);
            this.txtSearchGroup.Name = "txtSearchGroup";
            this.txtSearchGroup.Size = new System.Drawing.Size(168, 20);
            this.txtSearchGroup.TabIndex = 7;
            // 
            // txtMinGrade
            // 
            this.txtMinGrade.Location = new System.Drawing.Point(612, 138);
            this.txtMinGrade.Name = "txtMinGrade";
            this.txtMinGrade.Size = new System.Drawing.Size(168, 20);
            this.txtMinGrade.TabIndex = 8;
            // 
            // cmbSearchSubject
            // 
            this.cmbSearchSubject.FormattingEnabled = true;
            this.cmbSearchSubject.Location = new System.Drawing.Point(612, 98);
            this.cmbSearchSubject.Name = "cmbSearchSubject";
            this.cmbSearchSubject.Size = new System.Drawing.Size(168, 21);
            this.cmbSearchSubject.TabIndex = 9;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(612, 164);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(168, 23);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Фильтр";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(612, 193);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(168, 23);
            this.btnResetFilter.TabIndex = 13;
            this.btnResetFilter.Text = "Сбросить фильтр";
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(608, 262);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(168, 21);
            this.cmbSort.TabIndex = 12;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(608, 289);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(168, 23);
            this.btnSort.TabIndex = 14;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnIndividualTask
            // 
            this.btnIndividualTask.Location = new System.Drawing.Point(612, 353);
            this.btnIndividualTask.Name = "btnIndividualTask";
            this.btnIndividualTask.Size = new System.Drawing.Size(168, 48);
            this.btnIndividualTask.TabIndex = 15;
            this.btnIndividualTask.Text = "Индивидуальное задание";
            this.btnIndividualTask.UseVisualStyleBackColor = true;
            this.btnIndividualTask.Click += new System.EventHandler(this.btnIndividualTask_Click);
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Location = new System.Drawing.Point(612, 407);
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(168, 41);
            this.btnSaveReport.TabIndex = 16;
            this.btnSaveReport.Text = "Сохранить отчёт";
            this.btnSaveReport.UseVisualStyleBackColor = true;
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(782, 5);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(257, 443);
            this.rtbOutput.TabIndex = 17;
            this.rtbOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Сртировать по:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Группа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Предмет:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Оценка:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 489);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnSaveReport);
            this.Controls.Add(this.btnIndividualTask);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.btnResetFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbSearchSubject);
            this.Controls.Add(this.txtMinGrade);
            this.Controls.Add(this.txtSearchGroup);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvStudents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет студентов на факультативы";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchGroup;
        private System.Windows.Forms.TextBox txtMinGrade;
        private System.Windows.Forms.ComboBox cmbSearchSubject;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnIndividualTask;
        private System.Windows.Forms.Button btnSaveReport;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

