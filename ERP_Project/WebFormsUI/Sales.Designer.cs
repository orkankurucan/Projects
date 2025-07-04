namespace WebFormsUI
{
    partial class Sales
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
            gbxCreateCustomer = new System.Windows.Forms.GroupBox();
            btnGoToUserPage = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            lblCountry = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            lblPostCode = new System.Windows.Forms.Label();
            tbxCountry = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            tbxCity = new System.Windows.Forms.TextBox();
            tbxPostCode = new System.Windows.Forms.TextBox();
            tbxCustomerAddress = new System.Windows.Forms.TextBox();
            tbxCustomerName = new System.Windows.Forms.TextBox();
            lblCustomerAddress = new System.Windows.Forms.Label();
            lblCustomerName = new System.Windows.Forms.Label();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            dgvCustomer = new System.Windows.Forms.DataGridView();
            gbxCreateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // gbxCreateCustomer
            // 
            gbxCreateCustomer.Controls.Add(btnGoToUserPage);
            gbxCreateCustomer.Controls.Add(btnSearch);
            gbxCreateCustomer.Controls.Add(lblCountry);
            gbxCreateCustomer.Controls.Add(lblCity);
            gbxCreateCustomer.Controls.Add(lblPostCode);
            gbxCreateCustomer.Controls.Add(tbxCountry);
            gbxCreateCustomer.Controls.Add(btnDelete);
            gbxCreateCustomer.Controls.Add(btnEdit);
            gbxCreateCustomer.Controls.Add(btnSave);
            gbxCreateCustomer.Controls.Add(tbxCity);
            gbxCreateCustomer.Controls.Add(tbxPostCode);
            gbxCreateCustomer.Controls.Add(tbxCustomerAddress);
            gbxCreateCustomer.Controls.Add(tbxCustomerName);
            gbxCreateCustomer.Controls.Add(lblCustomerAddress);
            gbxCreateCustomer.Controls.Add(lblCustomerName);
            gbxCreateCustomer.Location = new System.Drawing.Point(26, 16);
            gbxCreateCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxCreateCustomer.Name = "gbxCreateCustomer";
            gbxCreateCustomer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxCreateCustomer.Size = new System.Drawing.Size(400, 374);
            gbxCreateCustomer.TabIndex = 0;
            gbxCreateCustomer.TabStop = false;
            gbxCreateCustomer.Text = "Create Customer";
            // 
            // btnGoToUserPage
            // 
            btnGoToUserPage.Location = new System.Drawing.Point(169, 328);
            btnGoToUserPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGoToUserPage.Name = "btnGoToUserPage";
            btnGoToUserPage.Size = new System.Drawing.Size(184, 29);
            btnGoToUserPage.TabIndex = 14;
            btnGoToUserPage.Text = "Go To User Page";
            btnGoToUserPage.UseVisualStyleBackColor = true;
            btnGoToUserPage.Click += btnGoToUserPage_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(15, 328);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(132, 29);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new System.Drawing.Point(18, 220);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new System.Drawing.Size(60, 20);
            lblCountry.TabIndex = 13;
            lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new System.Drawing.Point(18, 185);
            lblCity.Name = "lblCity";
            lblCity.Size = new System.Drawing.Size(34, 20);
            lblCity.TabIndex = 12;
            lblCity.Text = "City";
            // 
            // lblPostCode
            // 
            lblPostCode.AutoSize = true;
            lblPostCode.Location = new System.Drawing.Point(18, 150);
            lblPostCode.Name = "lblPostCode";
            lblPostCode.Size = new System.Drawing.Size(75, 20);
            lblPostCode.TabIndex = 11;
            lblPostCode.Text = "Post Code";
            // 
            // tbxCountry
            // 
            tbxCountry.Location = new System.Drawing.Point(183, 213);
            tbxCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxCountry.Name = "tbxCountry";
            tbxCountry.Size = new System.Drawing.Size(100, 27);
            tbxCountry.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(278, 267);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(145, 268);
            btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(75, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(18, 268);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbxCity
            // 
            tbxCity.Location = new System.Drawing.Point(183, 178);
            tbxCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxCity.Name = "tbxCity";
            tbxCity.Size = new System.Drawing.Size(100, 27);
            tbxCity.TabIndex = 3;
            // 
            // tbxPostCode
            // 
            tbxPostCode.Location = new System.Drawing.Point(183, 143);
            tbxPostCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxPostCode.Name = "tbxPostCode";
            tbxPostCode.Size = new System.Drawing.Size(100, 27);
            tbxPostCode.TabIndex = 2;
            // 
            // tbxCustomerAddress
            // 
            tbxCustomerAddress.Location = new System.Drawing.Point(183, 108);
            tbxCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxCustomerAddress.Name = "tbxCustomerAddress";
            tbxCustomerAddress.Size = new System.Drawing.Size(100, 27);
            tbxCustomerAddress.TabIndex = 1;
            // 
            // tbxCustomerName
            // 
            tbxCustomerName.Location = new System.Drawing.Point(183, 58);
            tbxCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxCustomerName.Name = "tbxCustomerName";
            tbxCustomerName.Size = new System.Drawing.Size(100, 27);
            tbxCustomerName.TabIndex = 0;
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.AutoSize = true;
            lblCustomerAddress.Location = new System.Drawing.Point(18, 108);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new System.Drawing.Size(129, 20);
            lblCustomerAddress.TabIndex = 10;
            lblCustomerAddress.Text = "Customer Address";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new System.Drawing.Point(15, 58);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new System.Drawing.Size(116, 20);
            lblCustomerName.TabIndex = 9;
            lblCustomerName.Text = "Customer Name";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvCustomer
            // 
            dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new System.Drawing.Point(465, 44);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new System.Drawing.Size(970, 545);
            dgvCustomer.TabIndex = 1;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // Sales
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1447, 634);
            Controls.Add(dgvCustomer);
            Controls.Add(gbxCreateCustomer);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Sales";
            Text = "Sales";
            Load += Sales_Load;
            gbxCreateCustomer.ResumeLayout(false);
            gbxCreateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCreateCustomer;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxPostCode;
        private System.Windows.Forms.TextBox tbxCustomerAddress;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnGoToUserPage;
    }
}