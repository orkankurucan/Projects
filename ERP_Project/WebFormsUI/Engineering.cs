using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebFormsUI
{
    public partial class Engineering : Form
    {
        private IProductService _productService;
        private IComponentService _componentService;
        private IProductComponentService _productComponentService;
        public Engineering()
        {
            InitializeComponent();
            _productService = new ProductManager(new ProductDal());
            _componentService = new ComponentManager(new ComponentDal());
            _productComponentService = new ProductComponentManager(new ProductComponentDal());
        }

        private void Engineering_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadComponents();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadProducts()
        {
            dgvProduct.DataSource = _productComponentService.ProductDetails();

        }

        private void LoadComponents()
        {
            var components = _componentService.GetAll();
            cbxComponents.DataSource = components;
            cbxComponents.DisplayMember = "ComponentCode";
            cbxComponents.ValueMember = "ComponentId";
            cbxComponents.SelectedValue = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
            LoadProducts();
            ClearTexts();
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateProduct();
            LoadProducts();

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
            LoadProducts();
        }

       

       

        private void tbxProductCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string productCode = tbxProductCode.Text.Trim();
                if (!string.IsNullOrEmpty(productCode))
                {
                    var product = _productService.GetProductByCode(tbxProductCode.Text);

                    if (product != null)
                    {
                        tbxProductDefinition.Text = product.ProductDefinition;
                        tbxVersion.Text = product.ProductVersion.ToString();
                    }
                    else
                    {
                        tbxComponentDefinition.Text = string.Empty;

                    }
                }
                else
                {
                    tbxProductDefinition.Text = string.Empty;
                    tbxVersion.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvProduct.CurrentRow;
            var productCodeValue = data.Cells["ProductCode"].Value;
            tbxProductCode.Text = productCodeValue != null ? productCodeValue.ToString() : string.Empty;
            var productDefinitionValue = data.Cells["ProductDefinition"].Value;
            tbxProductDefinition.Text = productDefinitionValue != null ? productDefinitionValue.ToString() : string.Empty;
            var productVersionValue = data.Cells["ProductVersion"].Value;
            tbxVersion.Text = productVersionValue != null ? productVersionValue.ToString() : string.Empty;
            var componentCodeValue = data.Cells["ComponentCode"].Value;
            cbxComponents.Text = componentCodeValue != null ? componentCodeValue.ToString() : string.Empty;
            var componentDefinitionValue = data.Cells["ComponentDefinition"].Value;
            tbxComponentDefinition.Text = componentDefinitionValue != null ? componentDefinitionValue.ToString() : string.Empty;
            var quantity = data.Cells["ComponentQuantity"].Value;
            tbxQuantity.Text = quantity != null ? quantity.ToString() : string.Empty;

            if (e.RowIndex >= 0)
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

        private void ClearTexts()
        {
            tbxProductCode.Clear();
            tbxProductDefinition.Clear();
            tbxVersion.Clear();
            cbxComponents.SelectedValue = -1;
            tbxComponentDefinition.Clear();
            tbxQuantity.Clear();
        }

        private void tbxVersion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool CheckTexts()
        {
            if (string.IsNullOrWhiteSpace(tbxProductCode.Text))
            {
                MessageBox.Show("Please fill all the related areas" + tbxProductCode.Text);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tbxProductDefinition.Text))
            {
                MessageBox.Show("Please fill all the related areas" + tbxProductDefinition.Text);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tbxVersion.Text))
            {
                MessageBox.Show("Please fill all the related areas" + tbxVersion.Text);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cbxComponents.Text))
            {
                MessageBox.Show("Please fill all the related areas" + cbxComponents.Text);
                return false;

            }
            else if (string.IsNullOrWhiteSpace(tbxComponentDefinition.Text))
            {
                MessageBox.Show("Please fill all the related areas" + tbxComponentDefinition.Text);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tbxQuantity.Text))
            {
                MessageBox.Show("Please fill all the related areas" + tbxQuantity.Text);
                return false;
            }

            else
                return true;
        }

        private void dgvProduct_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnGoToUserPage_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
            this.Close();
        }



        private void cbxComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string componentCode = cbxComponents.Text.Trim();

                if (!string.IsNullOrWhiteSpace(componentCode))
                {
                    var component = _componentService.GetByCode(componentCode);

                    if (component != null)
                    {
                        tbxComponentDefinition.Text = component.ComponentDefinition;
                    }
                    else
                    {
                        tbxComponentDefinition.Text = string.Empty;
                    }
                }
                else
                {
                    tbxComponentDefinition.Text = string.Empty;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void AddProduct()
        {
            try
            {
                if (CheckTexts())
                {
                    var existingProduct = _productService.GetProductByCode(tbxProductCode.Text.Trim());

                    if (existingProduct != null)
                    {
                        if (_productComponentService.GetAll().Any() == true)
                        {
                            var existingComponents = _productComponentService.GetAll()
                                .Where(x => x.ProductId == existingProduct.ProductId)
                                .Select(x => x.ComponentId)
                                .ToList();

                            int valueMember = Convert.ToInt32(cbxComponents.SelectedValue);

                            if (existingComponents.Contains(Convert.ToInt32(cbxComponents.SelectedValue)))
                            {
                                MessageBox.Show($"Product {existingProduct.ProductCode} is already bound to component {cbxComponents.Text}.");
                                return;
                            }
                            else
                            {
                                if (existingProduct.ProductComponents == null)
                                {
                                    existingProduct.ProductComponents = new List<ProductComponent>();
                                }

                                var component = _componentService.GetByCode(cbxComponents.Text);
                                MessageBox.Show($"Adding Component: {component.ComponentCode}");
                                var newProductComponent = new ProductComponent()
                                {
                                    ProductId = existingProduct.ProductId,
                                    ComponentId = component.ComponentId,
                                    ComponentQuantity = Convert.ToInt32(tbxQuantity.Text.Trim())
                                };
                                _productComponentService.Add(newProductComponent);

                                existingProduct = new Product()
                                {
                                    ProductId = existingProduct.ProductId,
                                    ProductCode = tbxProductCode.Text.Trim(),
                                    ProductDefinition = tbxProductDefinition.Text.Trim(),
                                    ProductVersion = Convert.ToInt32(tbxVersion.Text.Trim()),
                                    ProductComponents = new List<ProductComponent>()
                                };
                                _productService.Update(existingProduct, out string message);
                                MessageBox.Show("Component added to the existing product.");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Creating new product");
                        var product = new Product()
                        {
                            ProductCode = tbxProductCode.Text.Trim(),
                            ProductDefinition = tbxProductDefinition.Text.Trim(),
                            ProductVersion = Convert.ToInt32(tbxVersion.Text.Trim()),
                            ProductComponents = new List<ProductComponent>()
                        };

                        var component = _componentService.GetByCode(cbxComponents.Text);
                        product.ProductComponents.Add(new ProductComponent()
                        {
                            ComponentId = component.ComponentId,
                            ComponentQuantity = Convert.ToInt32(tbxQuantity.Text.Trim())
                        });

                        _productService.Add(product);
                        MessageBox.Show("New product created with the component.");
                    }


                    tbxProductCode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void UpdateProduct()
        {
            try
            {
                if (CheckTexts())
                {
                    var product = _productService.GetProductById(Convert.ToInt32(dgvProduct.CurrentRow.Cells["ProductID"].Value));
                    var component = _componentService.GetByCode(cbxComponents.Text);
                    if (product.ProductComponents == null)
                        product.ProductComponents = new List<ProductComponent>();

                    var existingComponents = _productComponentService.GetAll()
                               .Where(x => x.ProductId == product.ProductId)
                               .Select(x => x.ComponentId)
                               .ToList();
                    product = new Product()
                    {
                        ProductId = Convert.ToInt32(dgvProduct.CurrentRow.Cells["ProductID"].Value),
                        ProductCode = tbxProductCode.Text.Trim(),
                        ProductDefinition = tbxProductDefinition.Text.Trim(),
                        ProductVersion = Convert.ToInt32(tbxVersion.Text.Trim()),
                        ProductComponents = new List<ProductComponent>()

                    };
                    var existingComponentId = (Convert.ToInt32(dgvProduct.CurrentRow.Cells["ComponentId"].Value));
                    var componentProduct = _productComponentService.GetAll()
                        .Where(x => x.ProductId == product.ProductId)
                        .ToList();

                    var productComponentId = componentProduct.FirstOrDefault(x => x.ComponentId == existingComponentId);

                    var newProductComponent = new ProductComponent()
                    {
                        ProductComponentId = productComponentId.ProductComponentId,
                        ProductId = product.ProductId,
                        ComponentId = component.ComponentId,
                        ComponentQuantity = Convert.ToInt32(tbxQuantity.Text.Trim()),

                    };
                    _productComponentService.Update(newProductComponent);


                    _productService.Update(product, out string message);
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
         private void DeleteProduct()
        {
            try
            {
                var componentProduct = _productComponentService.GetAll()
                        .Where(x => x.ProductId == (Convert.ToInt32(dgvProduct.CurrentRow.Cells["ProductId"].Value)))
                        .ToList();

                var productComponentToDelete = componentProduct.FirstOrDefault(x => x.ComponentId == (Convert.ToInt32(dgvProduct.CurrentRow.Cells["ComponentId"].Value)));

                if (dgvProduct.RowCount > 0)
                {

                    DialogResult result = MessageBox.Show("Press Yes to delete Product, No to delete BOM.",
                                         "Delete Option",
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _productService.Delete(new Product()
                        {
                            ProductId = Convert.ToInt32(dgvProduct.CurrentRow.Cells["ProductId"].Value)
                        }, out string message);

                        var productComponent = _productComponentService.GetComponentsByProductId(Convert.ToInt32(dgvProduct.CurrentRow.Cells["ProductID"].Value));
                        foreach (var pc in productComponent)
                        {
                            _productComponentService.Delete(pc);
                        }

                        MessageBox.Show(message);

                    }


                    else if (result == DialogResult.No)
                    {
                        _productComponentService.Delete(new ProductComponent()
                        {
                            ProductComponentId = productComponentToDelete.ProductComponentId,
                            ProductId = Convert.ToInt32(dgvProduct.CurrentRow.Cells["ProductId"].Value)
                        });

                        MessageBox.Show("BOM Entity Deleted");
                    }

                    else if (result == DialogResult.Cancel)
                    {
                        return;
                        MessageBox.Show("Deletion cancelled.");
                    }


                    

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



