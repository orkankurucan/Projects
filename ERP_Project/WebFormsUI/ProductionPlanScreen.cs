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
    public partial class ProductionPlanScreen : Form
    {
        private IProductionPlanService _productionPlanService;

        public ProductionPlanScreen()
        {
            InitializeComponent();
            _productionPlanService = new ProductionPlanManager(new OrderDal(),
             new OrderDetailDal(),
             new ProductComponentDal(),
             new ComponentDal(),
             new InventoryDal(),
             new MachineDal(),
             new ComponentMachineDal(),
             new ProductionPlanDal(),
             new ProductDal());


        }


        private void ProductionPlanScreen_Load(object sender, EventArgs e)
        {
            LoadProductionPlan();
            dgvProductionPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void LoadProductionPlan()
        {
           var productionPlans = _productionPlanService.GetAll();
            dgvProductionPlan.DataSource = productionPlans;

            if (productionPlans == null || !productionPlans.Any())
            {
                MessageBox.Show("No production plans available.");
                return;
            }

        }

        private void btnGoToUserPage_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
            this.Close();
        }

        private void dgvProductionPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnShowPlans_Click(object sender, EventArgs e)
        {
            _productionPlanService.CreateProductionPlan();
        }
    }
}
