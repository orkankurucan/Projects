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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Transactions;
using System.Data.SqlClient;
using Enums;


namespace WebFormsUI
{
    public partial class CreateOrder : Form
    {
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
        private IProductService _productService;
        private ICustomerService _customerService;
        private IComponentService _componentService;

        public CreateOrder()
        {
            InitializeComponent();
            _orderService = new OrderManager(new OrderDal());
            _orderDetailService = new OrderDetailManager(new OrderDetailDal());
            _productService = new ProductManager(new ProductDal());
            _customerService = new CustomerManager(new CustomerDal());
            _componentService = new ComponentManager(new ComponentDal());
        }
         private void LoadOrders()
        {
            dgvOrders.DataSource = _orderDetailService.OrderInformation();
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            LoadOrders();
            LoadCustomers();
            LoadProducts();
            btnDeleteOrder.Enabled = false;
            btnEditOrder.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuildOrder();
            LoadOrders();
        }
       

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DeleteOrder();
            LoadOrders();
        }

       
        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            UpdateOrder();
            LoadOrders();
        }

         private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AllocateData();
            ActivateEditAndDelete();
        }


        private bool CheckTexts()
        {
            if (string.IsNullOrWhiteSpace(cbxCustomers.Text.Trim()))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tbxOrderNumber.Text.Trim()))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(dtpOrderDate.Text.Trim()))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(dtpDeliveryDate.Text.Trim()))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tbxQuantity.Text.Trim()))
            {
                MessageBox.Show("Please fill all related areas");
                return false;
            }

            else
                return true;
        }

        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BuildOrder()
        {
            try
            {
                if (CheckTexts())
                {
                    var customer = _customerService.Get(cbxCustomers.Text.Trim());
                    if (customer != null)
                    {
                        var newOrder = new Order()
                        {
                            CustomerId = customer.CustomerId,
                            CustomerOrderNumber = tbxOrderNumber.Text.Trim(),
                            OrderDate = dtpOrderDate.Value,
                            DeliveryDate = dtpDeliveryDate.Value,
                            OrderStatus = Enums.OrderStatus.Pending,

                        };


                        var orderedProduct = _productService.GetProductByCode(cbxProducts.Text);

                        newOrder.OrderDetails = new List<OrderDetail>();
                        var orderDetails = new OrderDetail()
                        {
                            OrderId = newOrder.OrderId,
                            ProductId = orderedProduct.ProductId,
                            CustomerId = customer.CustomerId,
                            Quantity = Convert.ToInt32(tbxQuantity.Text.Trim())
                        };
                        newOrder.OrderDetails.Add(orderDetails);
                        _orderService.Add(newOrder);

                        MessageBox.Show("Order Created");

                    }
                    else
                    {
                        MessageBox.Show("Customer Doesn't Exist");
                        return;
                    }
                }
                else
                    return;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void ActivateEditAndDelete()
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                btnEditOrder.Enabled = true;
                btnDeleteOrder.Enabled = true;
            }
            else
            {
                btnEditOrder.Enabled = false;
                btnDeleteOrder.Enabled = false;
            }
        }
        private void AllocateData()
        {
            var data = dgvOrders.CurrentRow;
            cbxCustomers.Text = data.Cells["CustomerName"].Value.ToString();
            tbxOrderNumber.Text = data.Cells["CustomerOrderNumber"].Value.ToString();
            dtpOrderDate.Value = Convert.ToDateTime(data.Cells["OrderDate"].Value);
            cbxProducts.Text = data.Cells["ProductCode"].Value.ToString();
            tbxQuantity.Text = data.Cells["Quantity"].Value.ToString();
            dtpDeliveryDate.Value = Convert.ToDateTime(data.Cells["DeliveryDate"].Value);
        }
        private void DeleteOrder()
        {
            try
            {
                if (dgvOrders.Rows.Count > 0)
                {
                    _orderDetailService.Delete(new OrderDetail()
                    {
                        OrderDetailId = Convert.ToInt32(dgvOrders.CurrentRow.Cells["OrderDetailId"].Value)

                    });

                    _orderService.Delete(new Order()
                    {
                        OrderId = Convert.ToInt32(dgvOrders.CurrentRow.Cells["OrderId"].Value)
                    });
                    MessageBox.Show("Order Deleted");
                }
                else
                {
                    MessageBox.Show("Nothing to Delete");
                    return;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void UpdateOrder()
        {
            try
            {
                if (CheckTexts())
                {
                    var order = _orderService.GetOrderByNumber(tbxOrderNumber.Text);
                    var product = _productService.GetProductByCode(cbxProducts.Text);
                    var customerId = _customerService.GetCustomerId(cbxCustomers.Text);
                    _orderService.Update(new Order()
                    {
                        OrderId = Convert.ToInt32(dgvOrders.CurrentRow.Cells["OrderId"].Value),
                        CustomerId = customerId,
                        CustomerOrderNumber = tbxOrderNumber.Text.Trim(),
                        OrderDate = dtpOrderDate.Value,
                        DeliveryDate = dtpDeliveryDate.Value,
                        OrderStatus = Enums.OrderStatus.Pending
                    });

                    _orderDetailService.Update(new OrderDetail()
                    {
                        OrderDetailId = Convert.ToInt32(dgvOrders.CurrentRow.Cells["OrderDetailId"].Value),
                        OrderId = order.OrderId,
                        ProductId = product.ProductId,
                        CustomerId = customerId,
                        Quantity = Convert.ToInt32(tbxQuantity.Text.Trim()),

                    }, out string message);
                    MessageBox.Show(message);
                }


                else
                    return;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void LoadProducts()
        {
            cbxProducts.DataSource = _productService.GetAll();
            cbxProducts.DisplayMember = "ProductCode";
            cbxProducts.ValueMember = "ProductId";
            cbxProducts.SelectedValue = "Select";
            cbxProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxProducts.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void LoadCustomers()
        {
            cbxCustomers.DataSource = _customerService.GetAll();
            cbxCustomers.DisplayMember = "CustomerName";
            cbxCustomers.ValueMember = "CustomerID";
            cbxCustomers.SelectedValue = "Select";
            cbxCustomers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxCustomers.AutoCompleteSource = AutoCompleteSource.ListItems;
        }



    }

}

