using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;

namespace WebFormsUI
{
    public partial class ChangePassword : Form
    {
        private IUserService _userService;
        public ChangePassword()
        {
            InitializeComponent();
            _userService = new UserManager(new UserDal());
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void CreatePassword()
        {
            UpdatePassword();
        }

        

        private void btnConfirmNewPassword_Click(object sender, EventArgs e)
        {
            CreatePassword();
        }

        private void btnGoToUserPage_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
            this.Close();
        }

        private void UpdatePassword()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxEnterNewPassword.Text) || string.IsNullOrWhiteSpace(tbxReEnterNewPassword.Text))
                {
                    MessageBox.Show(" Please fill all areas");
                    return;
                }
                var user = _userService.GetUserByUserId(SessionManager.LoggedInUserId);
                if ((tbxEnterNewPassword.Text.Trim() == tbxReEnterNewPassword.Text.Trim()))
                {
                    _userService.Update(new Entities.Concrete.Users()
                    {
                        UserId = user.UserId,
                        UserName = user.UserName,
                        UserPassword = tbxEnterNewPassword.Text.Trim(),
                        Name = user.Name,
                        Surname = user.Surname,
                        DepartmentId = user.DepartmentId,
                        RoleId = user.RoleId,
                        PhoneNumber = user.PhoneNumber,
                        SupervisorUserName = user.SupervisorUserName,
                        Address = user.Address

                    }, out string message);

                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Passwords don't match");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
