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
using System.Xml.Linq;

namespace WebFormsUI
{
    public partial class SupplierScreen : Form
    {
        private ISupplierService _supplierService;

        public SupplierScreen()
        {
            InitializeComponent();
            _supplierService = new SupplierManager(new SupplierDal());
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }



        private void LoadSuppliers()
        {
            dgvSupplier.DataSource = _supplierService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSupplier();
            LoadSuppliers();
            ClearTexts();
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateSupplier();
            ClearTexts();
            LoadSuppliers();

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSupplier();
            LoadSuppliers();
        }

        

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvSupplier.CurrentRow;
            tbxSupplierName.Text = data.Cells[1].Value.ToString();
            var addressParts = data.Cells[2].Value.ToString().Split(new[] { ";" }, StringSplitOptions.None);
            tbxSupplierAddress.Text = addressParts[0];
            tbxPostCode.Text = addressParts[1];
            tbxCity.Text = addressParts[2];
            tbxCountry.Text = addressParts[3];
        }

        private void ClearTexts()
        {
            tbxSupplierName.Clear();
            tbxSupplierAddress.Clear();
            tbxPostCode.Clear();
            tbxCity.Clear();
            tbxCountry.Clear();
        }

        private bool CheckTexts()
        {
            if (string.IsNullOrWhiteSpace(tbxSupplierName.Text))
            {
                MessageBox.Show("No Data Entered " + tbxSupplierName.Text);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxSupplierAddress.Text))
            {
                MessageBox.Show("No Data Entered " + tbxSupplierAddress.Text);
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbxPostCode.Text))
            {
                MessageBox.Show("No Data Entered " + tbxPostCode.Text);
                return false;

            }

            if (string.IsNullOrWhiteSpace(tbxCity.Text))
            {
                MessageBox.Show("No Data Entered " + tbxCity.Text);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxCountry.Text))
            {
                MessageBox.Show("No Data Entered " + tbxCountry.Text);
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

        private void dgvSupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count > 0)
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

        private void AddSupplier()
        {
            try
            {
                if (CheckTexts())
                {
                    _supplierService.Add(new Supplier()
                    {
                        SupplierName = tbxSupplierName.Text.Trim(),
                        SupplierAddress = tbxSupplierAddress.Text.Trim() + ";" + tbxPostCode.Text.Trim() + ";" + tbxCity.Text.Trim() + ";"
                    + tbxCountry.Text.Trim(),

                    }, out string message);

                    MessageBox.Show(message);

                    tbxSupplierName.Focus();
                }
                else
                {
                    MessageBox.Show("Nothing to Create");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateSupplier()
        {
            try
            {
                if (CheckTexts())
                {
                    _supplierService.Update(new Supplier()
                    {
                        SupplierId = Convert.ToInt32(dgvSupplier.CurrentRow.Cells[0].Value),
                        SupplierName = tbxSupplierName.Text.Trim(),
                        SupplierAddress = tbxSupplierAddress.Text.Trim() + ";" + tbxPostCode.Text.Trim() + ";"
                    + tbxCity.Text.Trim() + ";" + tbxCountry.Text.Trim(),
                    }, out string message);
                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Nothing to update");
                    return;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteSupplier()
        {
            try
            {
                if (dgvSupplier.Rows.Count > 0)
                {
                    _supplierService.Delete(new Supplier()
                    {
                        SupplierId = Convert.ToInt32(dgvSupplier.CurrentRow.Cells[0].Value),
                    }, out string message);
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






    }
}

