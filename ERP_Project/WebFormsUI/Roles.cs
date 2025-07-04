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
using Entities.Concrete;

namespace WebFormsUI
{
    public partial class Roles : Form
    {
        private IRoleService _roleService;
        public Roles()
        {
            InitializeComponent();
            _roleService = new RoleManager(new RoleDal());
        }

        private void Role_Load(object sender, EventArgs e)
        {
            LoadRoles();
            tbxRoleName.Focus();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void LoadRoles()
        {
            dgvRoles.DataSource = _roleService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRole();
            LoadRoles();

        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRole();
            LoadRoles();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRole();
            LoadRoles();


        }

       

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxRoleName.Text = dgvRoles.CurrentRow.Cells[1].Value.ToString();
            ActivateUpdateAndDeleteButtons(e);
        }

        

        private void btnGoToUserPage_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
            this.Close();
        }
        private void AddRole()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxRoleName.Text))
                {
                    MessageBox.Show("No Data Entered");
                    return;
                }
                _roleService.Add(new Role
                {
                    RoleName = tbxRoleName.Text.Trim(),
                }, out string message);

                MessageBox.Show(message);
                tbxRoleName.Clear();

                tbxRoleName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteRole()
        {
            try
            {
                _roleService.Delete(new Role
                {
                    RoleId = Convert.ToInt32(dgvRoles.CurrentRow.Cells[0].Value),

                }, out string message);

                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private void UpdateRole()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxRoleName.Text))
                {
                    MessageBox.Show("No Data Entered");
                    return;
                }
                _roleService.Update(new Role
                {
                    RoleId = Convert.ToInt32(dgvRoles.CurrentRow.Cells[0].Value),
                    RoleName = tbxRoleName.Text.Trim(),
                }, out string message);

                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActivateUpdateAndDeleteButtons(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }





    }
}
