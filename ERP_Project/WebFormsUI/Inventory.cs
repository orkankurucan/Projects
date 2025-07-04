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
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;


namespace WebFormsUI
{
    public partial class Inventory : Form
    {
        private IInventoryService _inventoryService;
        private IProductService _productService;
        private IComponentService _componentService;
        public Inventory()
        {
            InitializeComponent();
            _inventoryService = new InventoryManager(new InventoryDal(), new PurchaseOrderDal(), new ComponentDal(),
                new ProductionPlanDal(), new OrderDal(), new OrderDetailDal());
            _productService = new ProductManager(new ProductDal());
            _componentService = new ComponentManager(new ComponentDal());

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            LoadInventory();

            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

        }

        private void LoadInventory()
        {
            dgvInventory.DataSource = _inventoryService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStock();
            LoadInventory();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStock();
            LoadInventory();
        }
         private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateStock();
            LoadInventory();
        }



        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxCode.Text = dgvInventory.CurrentRow.Cells["InventoryEntityCode"].Value.ToString();
            tbxQuantity.Text = dgvInventory.CurrentRow.Cells["StockQuantity"].Value.ToString();
            ActivateUpdateAndDeleteButtons();

        }

        private void ActivateUpdateAndDeleteButtons()
        {
            if (dgvInventory.SelectedRows.Count > 0)
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

        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void dgvInventory_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnGoToUserPage_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
            this.Close();
        }

       

        private void btnAddComponents_Click(object sender, EventArgs e)
        {
            _inventoryService.MarkComponentsAsArrived();
            LoadInventory();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            _inventoryService.CompleteProductionAndTransferToInventory();
            LoadInventory();
        }

        private void AddStock()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxCode.Text) || string.IsNullOrWhiteSpace(tbxQuantity.Text))
                {
                    MessageBox.Show("Please fill all related areas");
                    return;

                }
                var product = _productService.GetProductByCode(tbxCode.Text.Trim());
                var component = _componentService.GetByCode(tbxCode.Text.Trim());

                if (product == null && component == null)
                {
                    MessageBox.Show("Entered Code Doesn't Exist");
                    return;
                }

                if (product != null)
                {
                    var inventory = _inventoryService.GetByProductCode(product.ProductCode);
                    if (inventory == null)
                        _inventoryService.Add(new Inventories()
                        {
                            InventoryEntityId = product.ProductId,
                            InventoryEntityCode = product.ProductCode,
                            InventoryEntityDefinition = product.ProductDefinition,
                            StockQuantity = Convert.ToInt32(tbxQuantity.Text.Trim()),
                            Type = Enums.InventoryType.Product,

                        });
                    else
                    {
                        _inventoryService.Update(new Inventories()
                        {
                            InventoryId = inventory.InventoryId,
                            InventoryEntityId = inventory.InventoryEntityId,
                            InventoryEntityCode = inventory.InventoryEntityCode,
                            InventoryEntityDefinition = inventory.InventoryEntityDefinition,
                            StockQuantity = inventory.StockQuantity + Convert.ToInt32(tbxQuantity.Text.Trim()),
                            Type = Enums.InventoryType.Product

                        });


                    }


                    MessageBox.Show("Product Quantity Added");

                }

                if (component != null)
                {
                    var inventory = _inventoryService.GetByComponentCode(component.ComponentCode);
                    if (inventory == null)
                        _inventoryService.Add(new Inventories()
                        {
                            InventoryEntityId = component.ComponentId,
                            InventoryEntityCode = component.ComponentCode,
                            InventoryEntityDefinition = component.ComponentDefinition,
                            StockQuantity = Convert.ToInt32(tbxQuantity.Text.Trim()),
                            Type = Enums.InventoryType.Component,
                        });

                    else
                    {
                        _inventoryService.Update(new Inventories()
                        {
                            InventoryId = inventory.InventoryId,
                            InventoryEntityId = inventory.InventoryEntityId,
                            InventoryEntityCode = inventory.InventoryEntityCode,
                            InventoryEntityDefinition = inventory.InventoryEntityDefinition,
                            StockQuantity = inventory.StockQuantity + Convert.ToInt32(tbxQuantity.Text.Trim()),
                            Type = Enums.InventoryType.Component

                        });
                    }



                    MessageBox.Show("Component Quantity Added");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void DeleteStock()
        {
            try
            {
                if (dgvInventory.Rows.Count > 0)
                {
                    _inventoryService.Delete(new Inventories()
                    {
                        InventoryId = Convert.ToInt32(dgvInventory.CurrentRow.Cells[0].Value)
                    });

                    MessageBox.Show("Inventory Deleted");

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
        private void UpdateStock()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxCode.Text) || string.IsNullOrWhiteSpace(tbxQuantity.Text))
                {
                    MessageBox.Show("Please fill all related areas");
                    return;

                }
                if (dgvInventory.Rows.Count > 0)
                {
                    _inventoryService.Update(new Inventories()
                    {
                        InventoryId = Convert.ToInt32((dgvInventory.CurrentRow.Cells[0].Value)),
                        InventoryEntityCode = tbxCode.Text.Trim(),
                        StockQuantity = Convert.ToInt32(tbxQuantity.Text.Trim()),

                    });
                    MessageBox.Show("Inventory Updated");


                }

                else
                {
                    MessageBox.Show("Nothing to Update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }




    }


}

