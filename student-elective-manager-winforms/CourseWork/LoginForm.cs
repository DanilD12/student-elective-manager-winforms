using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Авторизация";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            if (UserStorage.ValidateUser(login, password))
            {
                Hide();

                MainForm mainForm = new MainForm();
                mainForm.FormClosed += (s, args) => this.Show();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}