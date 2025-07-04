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
    public partial class Screen : Form
    {
        private IScreenService _screenService;
        public Screen()
        {
            InitializeComponent();
            _screenService = new ScreenManager(new ScreenDal());
        }

        private void Screen_Load(object sender, EventArgs e)
        {
            LoadScreens();
            tbxScreenName.Focus();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        public void LoadScreens()
        {
            dgvScreen.DataSource = _screenService.GetAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddScreen();
            LoadScreens();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteScreen();
            LoadScreens();
        }



        private void dgvScreen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxScreenName.Text = dgvScreen.CurrentRow.Cells[1].Value.ToString();
            ActivateDeleteAndEditButtons();
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateScreen();
            LoadScreens();

        }

       
        private void btnGoToUserPage_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
            this.Close();
        }

        private void AddScreen()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxScreenName.Text))
                {
                    MessageBox.Show("No data entered");
                    return;
                }

                _screenService.Add(new Entities.Concrete.Screen
                {
                    ScreenName = tbxScreenName.Text.Trim(),
                }, out string message);

                MessageBox.Show(message);
                tbxScreenName.Clear();

                tbxScreenName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void DeleteScreen()
        {
            try
            {
                _screenService.Delete(new Entities.Concrete.Screen
                {
                    ScreenId = Convert.ToInt32(dgvScreen.CurrentRow.Cells[0].Value)
                }, out string message);

                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private void UpdateScreen()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxScreenName.Text))
                {
                    MessageBox.Show("No Data Entered");
                    return;
                }

                _screenService.Update(new Entities.Concrete.Screen
                {
                    ScreenId = Convert.ToInt32(dgvScreen.CurrentRow.Cells[0].Value),
                    ScreenName = tbxScreenName.Text.Trim(),
                }, out string message);

                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActivateDeleteAndEditButtons()
        {
            if (dgvScreen.SelectedRows.Count > 0)
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
    }
}
