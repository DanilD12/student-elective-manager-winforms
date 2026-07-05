namespace CourseWork
{
    partial class AddEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtAverageGrade = new System.Windows.Forms.TextBox();
            this.cmbEditField = new System.Windows.Forms.ComboBox();
            this.chkMath = new System.Windows.Forms.CheckBox();
            this.chkPhysics = new System.Windows.Forms.CheckBox();
            this.chkProgramming = new System.Windows.Forms.CheckBox();
            this.chkEnglish = new System.Windows.Forms.CheckBox();
            this.chkDatabases = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Средний балл";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Что редактировать";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дисциплины";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(148, 51);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(222, 20);
            this.txtFullName.TabIndex = 5;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(148, 85);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(222, 20);
            this.txtGroup.TabIndex = 6;
            // 
            // txtAverageGrade
            // 
            this.txtAverageGrade.Location = new System.Drawing.Point(148, 124);
            this.txtAverageGrade.Name = "txtAverageGrade";
            this.txtAverageGrade.Size = new System.Drawing.Size(222, 20);
            this.txtAverageGrade.TabIndex = 7;
            // 
            // cmbEditField
            // 
            this.cmbEditField.FormattingEnabled = true;
            this.cmbEditField.Location = new System.Drawing.Point(148, 158);
            this.cmbEditField.Name = "cmbEditField";
            this.cmbEditField.Size = new System.Drawing.Size(222, 21);
            this.cmbEditField.TabIndex = 8;
            this.cmbEditField.SelectedIndexChanged += new System.EventHandler(this.cmbEditField_SelectedIndexChanged);
            // 
            // chkMath
            // 
            this.chkMath.AutoSize = true;
            this.chkMath.Location = new System.Drawing.Point(148, 202);
            this.chkMath.Name = "chkMath";
            this.chkMath.Size = new System.Drawing.Size(89, 17);
            this.chkMath.TabIndex = 9;
            this.chkMath.Text = "Математика";
            this.chkMath.UseVisualStyleBackColor = true;
            // 
            // chkPhysics
            // 
            this.chkPhysics.AutoSize = true;
            this.chkPhysics.Location = new System.Drawing.Point(148, 227);
            this.chkPhysics.Name = "chkPhysics";
            this.chkPhysics.Size = new System.Drawing.Size(67, 17);
            this.chkPhysics.TabIndex = 10;
            this.chkPhysics.Text = "Физика";
            this.chkPhysics.UseVisualStyleBackColor = true;
            // 
            // chkProgramming
            // 
            this.chkProgramming.AutoSize = true;
            this.chkProgramming.Location = new System.Drawing.Point(148, 250);
            this.chkProgramming.Name = "chkProgramming";
            this.chkProgramming.Size = new System.Drawing.Size(127, 17);
            this.chkProgramming.TabIndex = 11;
            this.chkProgramming.Text = "Программирование";
            this.chkProgramming.UseVisualStyleBackColor = true;
            // 
            // chkEnglish
            // 
            this.chkEnglish.AutoSize = true;
            this.chkEnglish.Location = new System.Drawing.Point(249, 202);
            this.chkEnglish.Name = "chkEnglish";
            this.chkEnglish.Size = new System.Drawing.Size(115, 17);
            this.chkEnglish.TabIndex = 12;
            this.chkEnglish.Text = "Английский язык";
            this.chkEnglish.UseVisualStyleBackColor = true;
            // 
            // chkDatabases
            // 
            this.chkDatabases.AutoSize = true;
            this.chkDatabases.Location = new System.Drawing.Point(249, 227);
            this.chkDatabases.Name = "chkDatabases";
            this.chkDatabases.Size = new System.Drawing.Size(93, 17);
            this.chkDatabases.TabIndex = 13;
            this.chkDatabases.Text = "Базы данных";
            this.chkDatabases.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 30);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(249, 311);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 30);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 365);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkDatabases);
            this.Controls.Add(this.chkEnglish);
            this.Controls.Add(this.chkProgramming);
            this.Controls.Add(this.chkPhysics);
            this.Controls.Add(this.chkMath);
            this.Controls.Add(this.cmbEditField);
            this.Controls.Add(this.txtAverageGrade);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtAverageGrade;
        private System.Windows.Forms.ComboBox cmbEditField;
        private System.Windows.Forms.CheckBox chkMath;
        private System.Windows.Forms.CheckBox chkPhysics;
        private System.Windows.Forms.CheckBox chkProgramming;
        private System.Windows.Forms.CheckBox chkEnglish;
        private System.Windows.Forms.CheckBox chkDatabases;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}