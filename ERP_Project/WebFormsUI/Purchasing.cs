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
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace WebFormsUI
{
    public partial class Purchasing : Form
    {
        private IComponentService _componentService;
        private IComponentSupplierService _componentSupplierService;
        private ISupplierService _supplierService;
        public Purchasing()
        {
            InitializeComponent();
            _componentService = new ComponentManager(new ComponentDal());
            _componentSupplierService = new ComponentSupplierManager(new ComponentSupplierDal());
            _supplierService = new SupplierManager(new SupplierDal());
        }

        private void Purchasing_Load(object sender, EventArgs e)
        {
            LoadComponents();
            LoadSuppliers();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddComponent();
            LoadComponents();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteComponent();
            LoadComponents();
        }



        private void LoadComponents()
        {
            dgvComponent.DataSource = _componentSupplierService.ComponentDetails();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateComponent();
            LoadComponents();
            DeleteTextBox();
        }

       

        private void dgvComponent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxComponentCode.Text = dgvComponent.CurrentRow.Cells["ComponentCode"].Value.ToString();
            tbxComponentDefinition.Text = dgvComponent.CurrentRow.Cells["ComponentDefinition"].Value.ToString();
            cbxSupplier.Text = dgvComponent.CurrentRow.Cells["SupplierName"].Value.ToString();
            tbxUnitPrice.Text = dgvComponent.CurrentRow.Cells["ComponentUnitPrice"].Value.ToString();
            tbxMinimumOrderQuantity.Text = dgvComponent.CurrentRow.Cells["MinimumOrderQuantity"].Value.ToString();
            tbxLeadTime.Text = dgvComponent.CurrentRow.Cells["LeadTime"].Value.ToString();

        }

        private void DeleteTextBox()
        {
            tbxComponentCode.Clear();
            tbxComponentDefinition.Clear();
            cbxSupplier.SelectedValue = -1;
            tbxUnitPrice.Clear();
            tbxMinimumOrderQuantity.Clear();
            tbxLeadTime.Clear();
        }

        private void LoadSuppliers()
        {
            cbxSupplier.DataSource = _supplierService.GetAll();
            cbxSupplier.DisplayMember = "SupplierName";
            cbxSupplier.ValueMember = "SupplierID";
            cbxSupplier.SelectedValue = "Select";

        }




        private bool CheckTexts()
        {
            if (string.IsNullOrWhiteSpace(tbxComponentCode.Text))
            {
                MessageBox.Show("No Data Entered " + tbxComponentCode.Text);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxComponentDefinition.Text))
            {
                MessageBox.Show("No Data Entered " + tbxComponentDefinition.Text);
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbxUnitPrice.Text))
            {
                MessageBox.Show("No Data Entered " + tbxUnitPrice.Text);
                return false;

            }

            if (string.IsNullOrWhiteSpace(tbxMinimumOrderQuantity.Text))
            {
                MessageBox.Show("No Data Entered " + tbxMinimumOrderQuantity.Text);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxLeadTime.Text))
            {
                MessageBox.Show("No Data Entered " + tbxLeadTime.Text);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbxSupplier.Text))
            {
                MessageBox.Show("No Data Entered " + cbxSupplier.Text);
                return false;
            }
            else
                return true;

        }

        private void tbxUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }


            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

        }

        private void tbxMinimumOrderQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

        }
        private void tbxLeadTime_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvComponent_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvComponent.SelectedRows.Count > 0)
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

        private void AddComponent()
        {
            try
            {
                if (CheckTexts())
                {
                    var components = new Components()
                    {
                        ComponentCode = tbxComponentCode.Text.Trim(),
                        ComponentDefinition = tbxComponentDefinition.Text.Trim(),
                        ComponentUnitPrice = Convert.ToDecimal(tbxUnitPrice.Text.Trim()),
                        MinimumOrderQuantity = Convert.ToInt32(tbxMinimumOrderQuantity.Text.Trim()),
                        LeadTime = Convert.ToInt32(tbxLeadTime.Text.Trim()),
                        ComponentSuppliers = new List<ComponentSupplier>()
                    };

                    components.ComponentSuppliers.Add(new ComponentSupplier()
                    {
                        ComponentId = components.ComponentId,
                        SupplierId = _supplierService.Get(cbxSupplier.Text).SupplierId
                    });

                    _componentService.Add(components, out string message);
                    MessageBox.Show(message);


                }
                else
                {
                    MessageBox.Show("Please Fill All Related Areas");
                }


                tbxComponentCode.Focus();
                cbxSupplier.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteComponent()
        {
            try
            {
                if (dgvComponent.Rows.Count > 0)
                {
                    _componentService.Delete(new Components
                    {
                        ComponentId = Convert.ToInt32(dgvComponent.CurrentRow.Cells[0].Value)


                    }, out string message);

                    MessageBox.Show(message);

                    var componentSupplier = _componentSupplierService.GetByComponentId(Convert.ToInt32(dgvComponent.CurrentRow.Cells[0].Value));
                    foreach (var cs in componentSupplier)
                    {
                        _componentSupplierService.Delete(cs);
                    }

                }
                else
                {
                    MessageBox.Show("Nothing to delete");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private void UpdateComponent()
        {
            try
            {
                if (CheckTexts())
                {
                    var component = _componentService.GetById(Convert.ToInt32(dgvComponent.CurrentRow.Cells[0].Value));

                    component.ComponentId = Convert.ToInt32(dgvComponent.CurrentRow.Cells[0].Value);
                    component.ComponentCode = tbxComponentCode.Text.Trim();
                    component.ComponentDefinition = tbxComponentDefinition.Text.Trim();
                    component.ComponentUnitPrice = Convert.ToDecimal(tbxUnitPrice.Text.Trim());
                    component.MinimumOrderQuantity = Convert.ToInt32(tbxMinimumOrderQuantity.Text.Trim());
                    component.LeadTime = Convert.ToInt32(tbxLeadTime.Text.Trim());

                    if (component.ComponentSuppliers == null)
                        component.ComponentSuppliers = new List<ComponentSupplier>();

                    var existingComponentSuppliers = _componentSupplierService.GetByComponentId(component.ComponentId);
                    foreach (var ecs in existingComponentSuppliers)
                    {
                        _componentSupplierService.Delete(ecs);
                    }
                    var supplier = _supplierService.Get(cbxSupplier.Text);
                    var newComponentSupplier = new ComponentSupplier()
                    {
                        ComponentId = component.ComponentId,
                        SupplierId = supplier.SupplierId,
                    };

                    _componentSupplierService.Add(newComponentSupplier);
                    _componentService.Update(component, out string message);



                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Please Fill All Related Areas");
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
