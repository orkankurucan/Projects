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
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Abstract;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;




namespace WebFormsUI
{
    public partial class CreateUser : Form
    {
        private IUserService _userService;
        private IDepartmentService _departmentService;
        private IRoleService _roleService;
        private IUserScreenService _userScreenService;
        private IScreenService _screenService;


        public CreateUser()
        {
            InitializeComponent();
            _userService = new UserManager(new UserDal());
            _departmentService = new DepartmentManager(new DepartmentDal());
            _roleService = new RoleManager(new RoleDal());
            _screenService = new ScreenManager(new ScreenDal());
            _userScreenService = new UserScreenManager(new UserScreenDal());
        }



        private void CreateUser_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadCategories();
            LoadRoles();
            LoadScreens();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvUser.SelectionChanged += DgvUsers_SelectionChanged;
        }

        private void LoadRoles()
        {
            cbxRole.DataSource = _roleService.GetAll();
            cbxRole.DisplayMember = "RoleName";
            cbxRole.ValueMember = "RoleId";
            cbxRole.SelectedValue = -1;

        }

        private void LoadUsers()
        {
            dgvUser.DataSource = _userService.GetUserInformation();

        }
        private void LoadCategories()
        {
            cbxDepartment.DataSource = _departmentService.GetAll();
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "DepartmentId";
            cbxDepartment.SelectedValue = -1;
        }

        private void LoadScreens()
        {
            CreateScreenBoxes();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUserName.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            tbxPassword.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            tbxName.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            tbxSurname.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
            cbxDepartment.SelectedValue = dgvUser.CurrentRow.Cells[6].Value;
            cbxRole.SelectedValue = dgvUser.CurrentRow.Cells[8].Value;
            tbxPhoneNumber.Text = dgvUser.CurrentRow.Cells[9].Value.ToString();
            tbxSupervisor.Text = dgvUser.CurrentRow.Cells[10].Value.ToString();
            tbxAddress.Text = dgvUser.CurrentRow.Cells[11].Value.ToString();


        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            AddUser();
            LoadUsers();
            ClearTexts();
            UncheckBoxes();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
            LoadUsers();
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateUser();
            LoadUsers();
            ClearTexts();
            UncheckBoxes();
        }



        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(tbxUserName.Text))
            {
                MessageBox.Show("No Data Entered " + tbxUserName.Text);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxPassword.Text))
            {
                MessageBox.Show("No Data Entered " + tbxPassword.Text);
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbxName.Text))
            {
                MessageBox.Show("No Data Entered " + tbxName.Text);
                return false;

            }

            if (string.IsNullOrWhiteSpace(tbxSurname.Text))
            {
                MessageBox.Show("No Data Entered " + tbxSurname.Text);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbxDepartment.Text))
            {
                MessageBox.Show("No Data Entered " + cbxDepartment.Text);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbxRole.Text))
            {
                MessageBox.Show("No Data Entered " + cbxRole.Text);
                return false;

            }
            if (string.IsNullOrWhiteSpace(tbxPhoneNumber.Text))
            {
                MessageBox.Show("No Data Entered " + tbxPhoneNumber.Text);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxSupervisor.Text))
            {
                MessageBox.Show("No Data Entered " + tbxSupervisor.Text);
                return false;

            }
            if (string.IsNullOrWhiteSpace(tbxAddress.Text))
            {
                MessageBox.Show("No Data Entered " + tbxAddress.Text);
                return false;
            }

            else
                return true;
        }




        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvUser.CurrentRow;

            tbxUserName.Text = data.Cells["UserName"].Value.ToString();
            tbxPassword.Text = data.Cells["Password"].Value.ToString();
            tbxName.Text = data.Cells["Name"].Value.ToString();
            tbxSurname.Text = data.Cells["Surname"].Value.ToString();
            cbxDepartment.Text = data.Cells["Department"]?.Value.ToString();
            cbxRole.Text = data.Cells["Role"]?.Value.ToString();
            tbxPhoneNumber.Text = data.Cells["PhoneNumber"].Value.ToString();
            tbxSupervisor.Text = data.Cells["SupervisorUserName"].Value.ToString();
            tbxAddress.Text = data.Cells["Address"].Value.ToString();

            GetAuthorizedScreens(tbxUserName.Text);


        }

        private void tbxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ClearTexts()
        {
            tbxUserName.Text = string.Empty;
            tbxPassword.Text = string.Empty;
            tbxName.Text = string.Empty;
            tbxSurname.Text = string.Empty;
            cbxDepartment.Text = string.Empty;
            cbxRole.Text = string.Empty;
            tbxPhoneNumber.Text = string.Empty;
            tbxSupervisor.Text = string.Empty;
            tbxAddress.Text = string.Empty;

        }

        private void btnGoToUserPage_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
            this.Close();
        }


        private void CreateScreenBoxes()
        {
            try
            {
                flpScreens.Controls.Clear();

                var screens = _screenService.GetAll();

                foreach (var screen in screens)
                {
                    CheckBox cb = new CheckBox
                    {
                        Text = screen.ScreenName,  
                        Tag = screen.ScreenId      
                    };

                    flpScreens.Controls.Add(cb);
                }
            }
            catch(Exception ex) 
            { MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }


        private void UncheckBoxes()
        {
            foreach (CheckBox checkbox in flpScreens.Controls.OfType<CheckBox>())
            {
                checkbox.Checked = false;
            }
        }

        private bool IfBoxesChecked()
        {
            var isAnyChecked = flpScreens.Controls.OfType<CheckBox>().Any(cb => cb.Checked);

            if (isAnyChecked)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No checkboxes are checked.");
                return false;
            }
        }

        private void GetAuthorizedScreens(string userName)
        {
            try
            {
                var authorizedScreens = _userScreenService.GetAuthorizedScreens(userName);

                if (authorizedScreens != null)
                {
                    foreach (CheckBox cb in flpScreens.Controls.OfType<CheckBox>())
                    {
                        var screen = _screenService.GetByScreenName(cb.Text);

                        if (screen != null)
                        {
                            cb.Checked = authorizedScreens.Any(x => x.ScreenId == screen.ScreenId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void AddUser()
        {
            try
            {
                if (Check() && IfBoxesChecked())
                {
                    var user = new Users()
                    {
                        UserName = tbxUserName.Text.Trim(),
                        UserPassword = tbxPassword.Text.Trim(),
                        Name = tbxName.Text.Trim(),
                        Surname = tbxSurname.Text.Trim(),
                        DepartmentId = Convert.ToInt32(cbxDepartment.SelectedValue),
                        RoleId = Convert.ToInt32(cbxRole.SelectedValue),
                        PhoneNumber = tbxPhoneNumber.Text.Trim(),
                        SupervisorUserName = tbxSupervisor.Text.Trim(),
                        Address = tbxAddress.Text.Trim(),
                        UserScreens = new List<UserScreen>()
                    };

                    foreach (CheckBox cb in flpScreens.Controls.OfType<CheckBox>())
                    {
                        if (cb.Checked)
                        {
                            var screen = _screenService.GetByScreenName(cb.Text);

                            if (screen != null)
                            {
                                user.UserScreens.Add(new UserScreen
                                {
                                    ScreenId = screen.ScreenId,
                                    UserId = user.UserId
                                });
                            }
                        }
                    }

                    _userService.Add(user, out string message);


                    MessageBox.Show(message);
                    tbxUserName.Focus();


                }
                else
                {
                    MessageBox.Show("Please fill all areas");
                    return;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteUser()
        {
            try
            {
                if (dgvUser.RowCount > 0)
                {
                    var user = _userService.GetUserByUserId(Convert.ToInt32(dgvUser.CurrentRow.Cells[0].Value));

                    var userScreens = _userScreenService.GetByUserId(user.UserId).ToList();
                    foreach (var userScreen in userScreens)
                    {
                        _userScreenService.Delete(userScreen);
                    }

                    // Delete the user
                    _userService.Delete(user, out string message);

                    MessageBox.Show(message);


                }

                else
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateUser()
        {
            try
            {


                if (Check() && IfBoxesChecked())
                {

                    var user = _userService.GetUserByUserId(Convert.ToInt32(dgvUser.CurrentRow.Cells[0].Value));
                    user.UserScreens = new List<UserScreen>();
                    user.UserId = Convert.ToInt32(dgvUser.CurrentRow.Cells[0].Value);
                    user.UserName = tbxUserName.Text.Trim();
                    user.UserPassword = tbxPassword.Text.Trim();
                    user.Name = tbxName.Text.Trim();
                    user.Surname = tbxSurname.Text.Trim();
                    user.DepartmentId = Convert.ToInt32(cbxDepartment.SelectedValue);
                    user.RoleId = Convert.ToInt32(cbxRole.SelectedValue);
                    user.PhoneNumber = tbxPhoneNumber.Text.Trim();
                    user.SupervisorUserName = tbxSupervisor.Text.Trim();
                    user.Address = tbxAddress.Text.Trim();

                    if (user.UserScreens == null)
                    {
                        user.UserScreens = new List<UserScreen>();
                    }

                    var existingUserScreens = _userScreenService.GetByUserId(user.UserId).ToList();
                    foreach (var existingUserScreen in existingUserScreens)
                    {
                        _userScreenService.Delete(existingUserScreen);
                    }

                    foreach (CheckBox cb in flpScreens.Controls.OfType<CheckBox>())
                    {
                        if (cb.Checked)
                        {
                            var screen = _screenService.GetByScreenName(cb.Text);
                            if (screen != null)
                            {
                                var newUserScreen = new UserScreen
                                {
                                    UserId = user.UserId,
                                    ScreenId = screen.ScreenId
                                };
                                _userScreenService.Add(newUserScreen);
                            }
                        }
                    }

                    _userService.Update(user, out string message);

                    MessageBox.Show(message);

                }


                else
                {
                    MessageBox.Show("Please fill all areas");
                    return;
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


    }
}





