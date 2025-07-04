using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;


namespace WebFormsUI
{
    public partial class Departments : Form
    {
        private IDepartmentService _departmentService;
        public Departments()
        {
            InitializeComponent();

            _departmentService = new DepartmentManager(new DepartmentDal());
        }


        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Departments_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            tbxDepartmentName.Focus();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadDepartments()
        {
            dgvDepartment.DataSource = _departmentService.GetAll();
            tbxDepartmentName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDepartment();
            LoadDepartments();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDepartment();

            LoadDepartments();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDepartment();
            LoadDepartments();
        }

       

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxDepartmentId.Text = dgvDepartment.CurrentRow.Cells[0].Value.ToString();
            tbxDepartmentName.Text = dgvDepartment.CurrentRow.Cells[1].Value.ToString();
            ActivateUpdateAndDeleteButtons(e);
        }

       

        private void btnGoToUserPage_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
            this.Close();
        }
        private void AddDepartment()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxDepartmentName.Text))
                {
                    MessageBox.Show("No data entered");
                    return;
                }

                _departmentService.Add(new Department
                {
                    DepartmentName = tbxDepartmentName.Text.Trim(),
                }, out string message);

                MessageBox.Show(message);
                tbxDepartmentName.Clear();

                tbxDepartmentName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private void UpdateDepartment()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxDepartmentName.Text))
                {
                    MessageBox.Show("No Data Entered");
                    return;
                }

                _departmentService.Update(new Department
                {
                    DepartmentId = Convert.ToInt32(dgvDepartment.CurrentRow.Cells[0].Value),
                    DepartmentName = tbxDepartmentName.Text.Trim(),

                }, out string message);

                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteDepartment()
        {
            try
            {
                _departmentService.Delete(new Department
                {
                    DepartmentId = Convert.ToInt32(dgvDepartment.CurrentRow.Cells[0].Value),
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
