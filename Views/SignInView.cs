using Desafio2_PED_EduardoLopez.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2_PED_EduardoLopez
{
    public partial class SignInView : Form
    {
        private string Username = "admin";
        private string Password = "admin123";

        public SignInView()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SignIn()
        {
            string username = userTxt.Text;
            string password = passwordTxt.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isValid = username.Equals(Username) && password.Equals(Password);

            if (!isValid)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            DashboardView DashboardView = new DashboardView();
            DashboardView.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.SignIn();
        }

        private void passwordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void passwordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SignIn();
                return;
            }
        }
    }
}
