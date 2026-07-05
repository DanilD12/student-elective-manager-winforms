using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.Text = "Регистрация";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            if (UserStorage.UserExists(login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует.");
                return;
            }

            bool success = UserStorage.RegisterUser(login, password);

            if (success)
            {
                MessageBox.Show("Регистрация прошла успешно.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось зарегистрировать пользователя.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}