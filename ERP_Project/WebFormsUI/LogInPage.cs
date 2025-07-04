using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;




namespace WebFormsUI
{
    public partial class LogInPage : Form
    {
        private ILogInService _logInService;
        public LogInPage(ILogInService logInService)
        {
            InitializeComponent();
            _logInService = logInService;
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            AcceptLogIn();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnForgotMyPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your password is sent to your mobile");
        }

        private void btnChangeMyPassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
            this.Hide();
        }

        private void tbxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                AcceptLogIn();
            }
        }

        private void AcceptLogIn()
        {
            string userName = tbxUserName.Text.Trim();
            string password = tbxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Invalid User Name or Password");
                return;
            }

            try
            {
                var user = _logInService.LogIn(userName, password);
                if (user == null)
                {
                    MessageBox.Show(" Check username or password please, log In unsuccessful ");
                }
                else
                {
                    UserPage userPage = new UserPage();
                    userPage.Show();
                    this.Hide();

                }

            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                AcceptLogIn();
            }
        }
    }
}
