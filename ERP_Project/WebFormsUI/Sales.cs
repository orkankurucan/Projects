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
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace WebFormsUI
{
    public partial class Sales : Form
    {
        private ICustomerService _customerService;
        public Sales()
        {
            InitializeComponent();
            _customerService = new CustomerManager(new CustomerDal());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddCustomer();
            ClearTexts();
            LoadCustomers();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
            ClearTexts();
            LoadCustomers();

        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateCustomer();
            ClearTexts();
            LoadCustomers();
        }



        private void FillTexts()
        {
            if (string.IsNullOrWhiteSpace(tbxCustomerName.Text) == false)
            {
                var searchedCustomer = _customerService.Get(tbxCustomerName.Text.Trim());
                tbxCustomerName.Text = searchedCustomer.CustomerName;
                var addressParts = searchedCustomer.CustomerAddress.Split(new[] { ";" }, StringSplitOptions.TrimEntries);
                tbxCustomerAddress.Text = addressParts[0];
                tbxPostCode.Text = addressParts[1];
                tbxCity.Text = addressParts[2];
                tbxCountry.Text = addressParts[3];
            }

            else
            {
                MessageBox.Show("Please enter Customer Name");
                return;
            }

        }

        private void ClearTexts()
        {
            tbxCustomerName.Text = string.Empty;
            tbxCustomerAddress.Text = string.Empty;
            tbxPostCode.Text = string.Empty;
            tbxCity.Text = string.Empty;
            tbxCountry.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillTexts();
        }
        private void LoadCustomers()
        {
            dgvCustomer.DataSource = _customerService.GetAll();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbxCustomerName.Text = dgvCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
            var address = _customerService.Get(tbxCustomerName.Text).CustomerAddress.Split(new[] { ";" }, StringSplitOptions.TrimEntries);
            tbxCustomerAddress.Text = address[0];
            tbxPostCode.Text = address[1];
            tbxCity.Text = address[2];
            tbxCountry.Text = address[3];
            ActivateUpdateAndDeleteButtons();

        }

        private void ActivateUpdateAndDeleteButtons()
        {
            if (dgvCustomer.SelectedRows.Count > 0)
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

        private bool CheckTexts()
        {
            if (string.IsNullOrWhiteSpace(tbxCustomerName.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }

            else if (string.IsNullOrWhiteSpace(tbxCustomerAddress.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tbxPostCode.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tbxCity.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tbxCountry.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            else
                return true;



        }
        private void btnGoToUserPage_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
            this.Close();
        }

        private void AddCustomer()
        {
            try
            {
                string message;
                if (CheckTexts())
                {
                    _customerService.Add(new Customer()
                    {
                        CustomerName = tbxCustomerName.Text.Trim(),
                        CustomerAddress = tbxCustomerAddress.Text.Trim() + ";"
                        + tbxPostCode.Text.Trim() + ";" + tbxCity.Text.Trim() + ";" + tbxCountry.Text.Trim(),
                    }, out message);

                    MessageBox.Show(message);


                    tbxCustomerName.Focus();
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void DeleteCustomer()
        {
            try
            {
                string message;
                if (dgvCustomer.Rows.Count > 0)
                {
                    _customerService.Delete(new Customer()
                    {
                        CustomerId = _customerService.GetCustomerId(tbxCustomerName.Text),

                    }, out message);

                    MessageBox.Show(message);

                }
                else
                {
                    MessageBox.Show("Nothing to Delete");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void UpdateCustomer()
        {
            try
            {
                string message;
                if (CheckTexts())
                {
                    _customerService.Update(new Customer()
                    {
                        CustomerId = _customerService.GetCustomerId(tbxCustomerName.Text.Trim()),
                        CustomerName = tbxCustomerName.Text.Trim(),
                        CustomerAddress = tbxCustomerAddress.Text.Trim() + ";" + tbxPostCode.Text.Trim() + ";"
                    + tbxCity.Text.Trim() + ";" + tbxCountry.Text.Trim(),

                    }, out message);

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