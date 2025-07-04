namespace WebFormsUI
{
    partial class CreateOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxCreateOrder = new System.Windows.Forms.GroupBox();
            btnGoToUserPage = new System.Windows.Forms.Button();
            cbxProducts = new System.Windows.Forms.ComboBox();
            cbxCustomers = new System.Windows.Forms.ComboBox();
            btnDeleteOrder = new System.Windows.Forms.Button();
            btnEditOrder = new System.Windows.Forms.Button();
            dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            lblOrderDate = new System.Windows.Forms.Label();
            tbxOrderNumber = new System.Windows.Forms.TextBox();
            lblOrderNumber = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            tbxQuantity = new System.Windows.Forms.TextBox();
            lblDeliveryDate = new System.Windows.Forms.Label();
            lblQuantity = new System.Windows.Forms.Label();
            lblProductCode = new System.Windows.Forms.Label();
            lblCustomerNameForOrder = new System.Windows.Forms.Label();
            dgvOrders = new System.Windows.Forms.DataGridView();
            gbxCreateOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // gbxCreateOrder
            // 
            gbxCreateOrder.Controls.Add(btnGoToUserPage);
            gbxCreateOrder.Controls.Add(cbxProducts);
            gbxCreateOrder.Controls.Add(cbxCustomers);
            gbxCreateOrder.Controls.Add(btnDeleteOrder);
            gbxCreateOrder.Controls.Add(btnEditOrder);
            gbxCreateOrder.Controls.Add(dtpDeliveryDate);
            gbxCreateOrder.Controls.Add(dtpOrderDate);
            gbxCreateOrder.Controls.Add(lblOrderDate);
            gbxCreateOrder.Controls.Add(tbxOrderNumber);
            gbxCreateOrder.Controls.Add(lblOrderNumber);
            gbxCreateOrder.Controls.Add(btnAdd);
            gbxCreateOrder.Controls.Add(tbxQuantity);
            gbxCreateOrder.Controls.Add(lblDeliveryDate);
            gbxCreateOrder.Controls.Add(lblQuantity);
            gbxCreateOrder.Controls.Add(lblProductCode);
            gbxCreateOrder.Controls.Add(lblCustomerNameForOrder);
            gbxCreateOrder.Location = new System.Drawing.Point(12, 13);
            gbxCreateOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxCreateOrder.Name = "gbxCreateOrder";
            gbxCreateOrder.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxCreateOrder.Size = new System.Drawing.Size(331, 439);
            gbxCreateOrder.TabIndex = 2;
            gbxCreateOrder.TabStop = false;
            gbxCreateOrder.Text = "Create Order";
            // 
            // btnGoToUserPage
            // 
            btnGoToUserPage.Location = new System.Drawing.Point(208, 349);
            btnGoToUserPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGoToUserPage.Name = "btnGoToUserPage";
            btnGoToUserPage.Size = new System.Drawing.Size(71, 50);
            btnGoToUserPage.TabIndex = 17;
            btnGoToUserPage.Text = "Go To User Page";
            btnGoToUserPage.UseVisualStyleBackColor = true;
            btnGoToUserPage.Click += btnGoToUserPage_Click;
            // 
            // cbxProducts
            // 
            cbxProducts.FormattingEnabled = true;
            cbxProducts.Location = new System.Drawing.Point(142, 170);
            cbxProducts.Name = "cbxProducts";
            cbxProducts.Size = new System.Drawing.Size(100, 28);
            cbxProducts.TabIndex = 4;
            // 
            // cbxCustomers
            // 
            cbxCustomers.FormattingEnabled = true;
            cbxCustomers.Location = new System.Drawing.Point(142, 39);
            cbxCustomers.Name = "cbxCustomers";
            cbxCustomers.Size = new System.Drawing.Size(100, 28);
            cbxCustomers.TabIndex = 1;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new System.Drawing.Point(23, 370);
            btnDeleteOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new System.Drawing.Size(132, 29);
            btnDeleteOrder.TabIndex = 9;
            btnDeleteOrder.Text = "Delete Order";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnEditOrder
            // 
            btnEditOrder.Location = new System.Drawing.Point(23, 330);
            btnEditOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new System.Drawing.Size(132, 32);
            btnEditOrder.TabIndex = 8;
            btnEditOrder.Text = "Edit Order";
            btnEditOrder.UseVisualStyleBackColor = true;
            btnEditOrder.Click += btnEditOrder_Click;
            // 
            // dtpDeliveryDate
            // 
            dtpDeliveryDate.Location = new System.Drawing.Point(147, 245);
            dtpDeliveryDate.Name = "dtpDeliveryDate";
            dtpDeliveryDate.Size = new System.Drawing.Size(95, 27);
            dtpDeliveryDate.TabIndex = 6;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new System.Drawing.Point(145, 119);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new System.Drawing.Size(97, 27);
            dtpOrderDate.TabIndex = 3;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new System.Drawing.Point(20, 116);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new System.Drawing.Size(83, 20);
            lblOrderDate.TabIndex = 13;
            lblOrderDate.Text = "Order Date";
            // 
            // tbxOrderNumber
            // 
            tbxOrderNumber.Location = new System.Drawing.Point(142, 74);
            tbxOrderNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxOrderNumber.Name = "tbxOrderNumber";
            tbxOrderNumber.Size = new System.Drawing.Size(100, 27);
            tbxOrderNumber.TabIndex = 2;
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Location = new System.Drawing.Point(20, 81);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new System.Drawing.Size(105, 20);
            lblOrderNumber.TabIndex = 12;
            lblOrderNumber.Text = "Order Number";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(20, 290);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(259, 32);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Create Order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxQuantity
            // 
            tbxQuantity.Location = new System.Drawing.Point(142, 205);
            tbxQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxQuantity.Name = "tbxQuantity";
            tbxQuantity.Size = new System.Drawing.Size(100, 27);
            tbxQuantity.TabIndex = 5;
            tbxQuantity.KeyPress += tbxQuantity_KeyPress;
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new System.Drawing.Point(23, 247);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new System.Drawing.Size(99, 20);
            lblDeliveryDate.TabIndex = 16;
            lblDeliveryDate.Text = "Delivery Date";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new System.Drawing.Point(23, 212);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(65, 20);
            lblQuantity.TabIndex = 15;
            lblQuantity.Text = "Quantity";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new System.Drawing.Point(23, 178);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new System.Drawing.Size(99, 20);
            lblProductCode.TabIndex = 14;
            lblProductCode.Text = "Product Code";
            // 
            // lblCustomerNameForOrder
            // 
            lblCustomerNameForOrder.AutoSize = true;
            lblCustomerNameForOrder.Location = new System.Drawing.Point(20, 45);
            lblCustomerNameForOrder.Name = "lblCustomerNameForOrder";
            lblCustomerNameForOrder.Size = new System.Drawing.Size(116, 20);
            lblCustomerNameForOrder.TabIndex = 11;
            lblCustomerNameForOrder.Text = "Customer Name";
            // 
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new System.Drawing.Point(360, 25);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new System.Drawing.Size(1099, 413);
            dgvOrders.TabIndex = 3;
            dgvOrders.CellClick += dgvOrders_CellClick;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1459, 450);
            Controls.Add(dgvOrders);
            Controls.Add(gbxCreateOrder);
            Name = "CreateOrder";
            Text = "CreateOrder";
            Load += CreateOrder_Load;
            gbxCreateOrder.ResumeLayout(false);
            gbxCreateOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCreateOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblCustomerNameForOrder;
        private System.Windows.Forms.TextBox tbxOrderNumber;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.ComboBox cbxCustomers;
        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.Button btnGoToUserPage;
    }
}