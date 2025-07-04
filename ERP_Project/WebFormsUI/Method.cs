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
    public partial class Method : Form
    {
        private IMachineService _machineService;
        public Method()
        {
            InitializeComponent();
            _machineService = new MachineManager(new MachineDal());
        }

        private void Method_Load(object sender, EventArgs e)
        {
            LoadMachines();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadMachines()
        {
            dgvMachine.DataSource = _machineService.GetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddMachine();
            LoadMachines();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteMachine();
            LoadMachines();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateMachine();
            LoadMachines();
        }

       

        private bool CheckTexts()
        {
            if (string.IsNullOrWhiteSpace(tbxMachineName.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxMachineProcess.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxMachineCapacity.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            else
                return true;
        }

        private void dgvMachine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMachineName.Text = dgvMachine.CurrentRow.Cells["MachineName"].Value.ToString();
            tbxMachineProcess.Text = dgvMachine.CurrentRow.Cells["MachineProcess"].Value.ToString();
            tbxMachineCapacity.Text = dgvMachine.CurrentRow.Cells["CapacityPerDay"].Value.ToString();

            ActivateUpdateAndDeleteButton();
        }

        private void tbxMachineCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGoToUserPage_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
            this.Close();
        }

        private void ActivateUpdateAndDeleteButton()
        {
            if (dgvMachine.SelectedRows.Count > 0)
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
        private void AddMachine()
        {
            try
            {
                if (CheckTexts())
                {
                    _machineService.Add(new Machine()
                    {
                        MachineName = tbxMachineName.Text.Trim(),
                        MachineProcess = tbxMachineProcess.Text.Trim(),
                        CapacityPerDay = Convert.ToInt32(tbxMachineCapacity.Text.Trim())

                    }, out string message);

                    MessageBox.Show(message);

                }
                else
                    return;
            }
            catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
        }
        private void DeleteMachine()
        {
            try
            {
                if (dgvMachine.Rows.Count > 0)
                {
                    _machineService.Delete(new Machine()
                    {
                        MachineId = Convert.ToInt32(dgvMachine.CurrentRow.Cells[0].Value),
                    }, out string message);

                    MessageBox.Show(message);


                }
                else
                {
                    MessageBox.Show("Nothing to Delete");
                    return;
                }
            }
            catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
        }
         private void UpdateMachine()
        {
            try
            {
                if (CheckTexts())
                {
                    _machineService.Update(new Machine()
                    {
                        MachineId = (int)dgvMachine.CurrentRow.Cells[0].Value,
                        MachineName = tbxMachineName.Text.Trim(),
                        MachineProcess = tbxMachineProcess.Text.Trim(),
                        CapacityPerDay = Convert.ToInt32(tbxMachineCapacity.Text.Trim()),

                    }, out string message);

                    MessageBox.Show(message);

                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



    }
}
