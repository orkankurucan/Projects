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

namespace WebFormsUI
{
    public partial class ComponentBuy : Form
    {
        private IPurchaseOrderDetailService _purchaseOrderDetailService;
        public ComponentBuy()
        {
            InitializeComponent();
            _purchaseOrderDetailService = new PurchaseOrderDetailManager(new OrderDal(), new OrderDetailDal(),
            new ProductComponentDal(), new ComponentDal(), new InventoryDal(),
            new PurchaseOrderDal(), new ComponentSupplierDal());
        }

        private void ComponentBuyLoad(object sender, EventArgs e)
        {
            var purchaseOrders = _purchaseOrderDetailService.ComponentBuying();
            dgvComponentBuy.DataSource = purchaseOrders;
            dgvComponentBuy.Dock = DockStyle.Fill;

        }

        private void ComponentBuy_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
        }
    }
}
