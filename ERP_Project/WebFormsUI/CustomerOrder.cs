﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebFormsUI
{
    public partial class CustomerOrder : Form
    {
        public CustomerOrder()
        {
            InitializeComponent();
        }

        private void CustomerOrderLoad(object sender, EventArgs e)
        {

        }

        private void CustomerOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.Show();
        }
    }
}
