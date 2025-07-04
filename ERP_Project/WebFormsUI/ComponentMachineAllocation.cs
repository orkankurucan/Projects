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
using Microsoft.EntityFrameworkCore;

namespace WebFormsUI
{
    public partial class ComponentMachineAllocation : Form
    {
        private IProductService _productService;
        private IComponentService _componentService;
        private IProductComponentService _productComponentService;
        private IMachineService _machineService;
        private IComponentMachineService _componentMachineService;


        public ComponentMachineAllocation()
        {
            InitializeComponent();
            _productService = new ProductManager(new ProductDal());
            _componentService = new ComponentManager(new ComponentDal());
            _productComponentService = new ProductComponentManager(new ProductComponentDal());
            _machineService = new MachineManager(new MachineDal());
            _componentMachineService = new ComponentMachineManager(new ComponentMachineDal());
            cbxProducts.SelectedIndexChanged += cbxProducts_SelectedIndexChanged;
        }




        private void ComponentMachineAllocation_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadMachines();
            LoadComponentMachines();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadProducts()
        {

            cbxProducts.DataSource = _productService.GetAll();
            cbxProducts.DisplayMember = "ProductCode";
            cbxProducts.ValueMember = "ProductId";
            cbxProducts.SelectedValue = -1;
            cbxProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxProducts.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void LoadComponents(int productId)
        {
            try
            {
                var productComponents = _productComponentService.ShowAll()
                    .Where(x => x.ProductId == productId)
                    .Select(x => x.Component)
                    .ToList();


                if (productComponents == null || productComponents.Count == 0)
                {
                    MessageBox.Show("No components found for this product.");
                    cbxComponents.DataSource = null;
                    cbxComponents.Items.Clear();
                    return;
                }

                cbxComponents.DataSource = productComponents;
                cbxComponents.DisplayMember = "ComponentCode";
                cbxComponents.ValueMember = "ComponentId";
                cbxComponents.SelectedValue = -1;
                cbxComponents.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void LoadMachines()
        {
            cbxMachines.DataSource = _machineService.GetAll();
            cbxMachines.DisplayMember = "MachineName";
            cbxMachines.ValueMember = "MachineId";
            cbxMachines.SelectedValue = -1;
            cbxMachines.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxMachines.AutoCompleteSource = AutoCompleteSource.ListItems;
        }



        private void LoadComponentMachines()
        {
            dgvComponentMachine.DataSource = _componentMachineService.AllocationDetails();
        }


        private void cbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxProducts.SelectedIndex != -1)
                {
                    var product = (Product)cbxProducts.SelectedItem;
                    tbxProductDefinition.Text = product.ProductDefinition;
                    LoadComponents(product.ProductId);

                }
                else
                {
                    tbxProductDefinition.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }


        private void GenerateSubCode()
        {
            try
            {
                if (cbxProducts.SelectedItem != null && cbxComponents.SelectedItem != null && cbxMachines.SelectedItem != null)
                {
                    var product = (Product)cbxProducts.SelectedItem;
                    var component = (Components)cbxComponents.SelectedItem;
                    var machine = (Machine)cbxMachines.SelectedItem;

                    string subCode = $"{product.ProductCode}{component.ComponentCode}{machine.MachineName}";
                    tbxSubCode.Text = subCode;
                }
                else
                {
                    tbxSubCode.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void cbxComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = cbxComponents.SelectedItem;

                if (selectedItem is Components component)
                {
                    tbxComponentDefinition.Text = component.ComponentDefinition;
                }
                else
                    tbxComponentDefinition.Text = string.Empty;

                GenerateSubCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void cbxMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateSubCode();
        }

        private void dgvComponentMachine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvComponentMachine.CurrentRow;
            cbxComponents.Text = data.Cells["ComponentCode"].Value.ToString();
            tbxComponentDefinition.Text = data.Cells["ComponentDefinition"].Value.ToString();
            cbxMachines.Text = data.Cells["MachineName"].Value.ToString();
            tbxSubCode.Text = data.Cells["SubCode"].Value.ToString();

            ActivateUpdateAndDeleteButtons();

        }

        private void ActivateUpdateAndDeleteButtons()
        {
            if (dgvComponentMachine.SelectedRows.Count > 0)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddComponentMachine();
            LoadComponentMachines();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateComponentMachine();
            LoadComponentMachines();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteComponentMachine();
            LoadComponentMachines();
        }

       

        private bool CheckTexts()
        {
            if (string.IsNullOrWhiteSpace(cbxProducts.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxProductDefinition.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbxComponents.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxComponentDefinition.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbxMachines.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxSubCode.Text))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            else
                return true;

        }

        private void tbxCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUserPage_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
            this.Close();
        }

        private void AddComponentMachine()
        {
            try
            {
                if (CheckTexts())
                {
                    var machine = _machineService.Get(cbxMachines.Text.Trim());
                    var component = _componentService.GetByCode(cbxComponents.Text);
                    var componentMachine = _componentMachineService.GetBySubCode(tbxSubCode.Text.Trim());
                    var productId = _productService.GetProductId(cbxProducts.Text);
                    if (componentMachine == null)
                        _componentMachineService.Add(new ComponentMachine()
                        {
                            MachineId = Convert.ToInt32(machine.MachineId),
                            ComponentId = component.ComponentId,
                            ProductId = productId,
                            SubCode = tbxSubCode.Text
                        });

                    else
                    {
                        MessageBox.Show("This allocation is done before");
                        return;
                    }
                    MessageBox.Show("Component is Allocated");

                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void UpdateComponentMachine()
        {
            try
            {
                if (CheckTexts())
                {
                    var machine = _machineService.Get(cbxMachines.Text);
                    var component = _componentService.GetByCode(cbxComponents.Text);
                    var productId = _productService.GetProductId(cbxProducts.Text);
                    _componentMachineService.Update(new ComponentMachine()
                    {
                        ComponentMachineId = Convert.ToInt32(dgvComponentMachine.CurrentRow.Cells[0].Value),
                        MachineId = machine.MachineId,
                        ComponentId = component.ComponentId,
                        ProductId = productId,
                        SubCode = tbxSubCode.Text
                    });

                    MessageBox.Show("Allocation Edited");

                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
         private void DeleteComponentMachine()
        {
            try
            {
                if (dgvComponentMachine.Rows.Count > 0)
                {
                    _componentMachineService.Delete(new ComponentMachine()
                    {
                        ComponentMachineId = Convert.ToInt32(dgvComponentMachine.CurrentRow.Cells[0].Value)

                    });

                    MessageBox.Show("Allocation Deleted");
                    
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


    }
}
