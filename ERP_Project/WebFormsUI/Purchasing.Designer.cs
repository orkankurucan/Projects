namespace WebFormsUI
{
    partial class Purchasing
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
            gbxComponentDetails = new System.Windows.Forms.GroupBox();
            cbxSupplier = new System.Windows.Forms.ComboBox();
            tbxComponentCode = new System.Windows.Forms.TextBox();
            lblComponentCode = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            tbxLeadTime = new System.Windows.Forms.TextBox();
            tbxMinimumOrderQuantity = new System.Windows.Forms.TextBox();
            tbxUnitPrice = new System.Windows.Forms.TextBox();
            tbxComponentDefinition = new System.Windows.Forms.TextBox();
            lblLeadTime = new System.Windows.Forms.Label();
            lblMinimumOrderQuantity = new System.Windows.Forms.Label();
            lblUnitPrice = new System.Windows.Forms.Label();
            lblSupplier = new System.Windows.Forms.Label();
            lblComponentDefinition = new System.Windows.Forms.Label();
            dgvComponent = new System.Windows.Forms.DataGridView();
            btnGoToUserPage = new System.Windows.Forms.Button();
            gbxComponentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComponent).BeginInit();
            SuspendLayout();
            // 
            // gbxComponentDetails
            // 
            gbxComponentDetails.Controls.Add(cbxSupplier);
            gbxComponentDetails.Controls.Add(tbxComponentCode);
            gbxComponentDetails.Controls.Add(lblComponentCode);
            gbxComponentDetails.Controls.Add(btnDelete);
            gbxComponentDetails.Controls.Add(btnEdit);
            gbxComponentDetails.Controls.Add(btnSave);
            gbxComponentDetails.Controls.Add(tbxLeadTime);
            gbxComponentDetails.Controls.Add(tbxMinimumOrderQuantity);
            gbxComponentDetails.Controls.Add(tbxUnitPrice);
            gbxComponentDetails.Controls.Add(tbxComponentDefinition);
            gbxComponentDetails.Controls.Add(lblLeadTime);
            gbxComponentDetails.Controls.Add(lblMinimumOrderQuantity);
            gbxComponentDetails.Controls.Add(lblUnitPrice);
            gbxComponentDetails.Controls.Add(lblSupplier);
            gbxComponentDetails.Controls.Add(lblComponentDefinition);
            gbxComponentDetails.Location = new System.Drawing.Point(2, 11);
            gbxComponentDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxComponentDetails.Name = "gbxComponentDetails";
            gbxComponentDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxComponentDetails.Size = new System.Drawing.Size(448, 424);
            gbxComponentDetails.TabIndex = 0;
            gbxComponentDetails.TabStop = false;
            gbxComponentDetails.Text = "Component Details";
            // 
            // cbxSupplier
            // 
            cbxSupplier.FormattingEnabled = true;
            cbxSupplier.Location = new System.Drawing.Point(268, 134);
            cbxSupplier.Name = "cbxSupplier";
            cbxSupplier.Size = new System.Drawing.Size(97, 28);
            cbxSupplier.TabIndex = 2;
            // 
            // tbxComponentCode
            // 
            tbxComponentCode.Location = new System.Drawing.Point(268, 47);
            tbxComponentCode.Name = "tbxComponentCode";
            tbxComponentCode.Size = new System.Drawing.Size(100, 27);
            tbxComponentCode.TabIndex = 0;
            // 
            // lblComponentCode
            // 
            lblComponentCode.AutoSize = true;
            lblComponentCode.Location = new System.Drawing.Point(23, 47);
            lblComponentCode.Name = "lblComponentCode";
            lblComponentCode.Size = new System.Drawing.Size(126, 20);
            lblComponentCode.TabIndex = 10;
            lblComponentCode.Text = "Component Code";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(227, 326);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(125, 326);
            btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(75, 29);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(26, 327);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbxLeadTime
            // 
            tbxLeadTime.Location = new System.Drawing.Point(268, 257);
            tbxLeadTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxLeadTime.Name = "tbxLeadTime";
            tbxLeadTime.Size = new System.Drawing.Size(100, 27);
            tbxLeadTime.TabIndex = 5;
            tbxLeadTime.KeyPress += tbxLeadTime_KeyPress;
            // 
            // tbxMinimumOrderQuantity
            // 
            tbxMinimumOrderQuantity.Location = new System.Drawing.Point(268, 209);
            tbxMinimumOrderQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxMinimumOrderQuantity.Name = "tbxMinimumOrderQuantity";
            tbxMinimumOrderQuantity.Size = new System.Drawing.Size(100, 27);
            tbxMinimumOrderQuantity.TabIndex = 4;
            tbxMinimumOrderQuantity.KeyPress += tbxMinimumOrderQuantity_KeyPress;
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new System.Drawing.Point(268, 177);
            tbxUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new System.Drawing.Size(100, 27);
            tbxUnitPrice.TabIndex = 3;
            tbxUnitPrice.KeyPress += tbxUnitPrice_KeyPress;
            // 
            // tbxComponentDefinition
            // 
            tbxComponentDefinition.Location = new System.Drawing.Point(268, 99);
            tbxComponentDefinition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxComponentDefinition.Name = "tbxComponentDefinition";
            tbxComponentDefinition.Size = new System.Drawing.Size(100, 27);
            tbxComponentDefinition.TabIndex = 1;
            // 
            // lblLeadTime
            // 
            lblLeadTime.AutoSize = true;
            lblLeadTime.Location = new System.Drawing.Point(23, 254);
            lblLeadTime.Name = "lblLeadTime";
            lblLeadTime.Size = new System.Drawing.Size(116, 20);
            lblLeadTime.TabIndex = 15;
            lblLeadTime.Text = "Lead Time (day)";
            // 
            // lblMinimumOrderQuantity
            // 
            lblMinimumOrderQuantity.AutoSize = true;
            lblMinimumOrderQuantity.Location = new System.Drawing.Point(23, 215);
            lblMinimumOrderQuantity.Name = "lblMinimumOrderQuantity";
            lblMinimumOrderQuantity.Size = new System.Drawing.Size(213, 20);
            lblMinimumOrderQuantity.TabIndex = 14;
            lblMinimumOrderQuantity.Text = "Minimum Order Quantity (unit)";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new System.Drawing.Point(20, 170);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new System.Drawing.Size(113, 20);
            lblUnitPrice.TabIndex = 13;
            lblUnitPrice.Text = "Unit Price (GBP)";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new System.Drawing.Point(20, 134);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new System.Drawing.Size(64, 20);
            lblSupplier.TabIndex = 12;
            lblSupplier.Text = "Supplier";
            // 
            // lblComponentDefinition
            // 
            lblComponentDefinition.AutoSize = true;
            lblComponentDefinition.Location = new System.Drawing.Point(20, 92);
            lblComponentDefinition.Name = "lblComponentDefinition";
            lblComponentDefinition.Size = new System.Drawing.Size(157, 20);
            lblComponentDefinition.TabIndex = 11;
            lblComponentDefinition.Text = "Component Definition";
            // 
            // dgvComponent
            // 
            dgvComponent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvComponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComponent.Location = new System.Drawing.Point(456, 11);
            dgvComponent.Name = "dgvComponent";
            dgvComponent.RowHeadersWidth = 51;
            dgvComponent.Size = new System.Drawing.Size(969, 718);
            dgvComponent.TabIndex = 2;
            dgvComponent.CellClick += dgvComponent_CellClick;
            dgvComponent.SelectionChanged += dgvComponent_SelectionChanged;
            // 
            // btnGoToUserPage
            // 
            btnGoToUserPage.Location = new System.Drawing.Point(194, 452);
            btnGoToUserPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGoToUserPage.Name = "btnGoToUserPage";
            btnGoToUserPage.Size = new System.Drawing.Size(146, 104);
            btnGoToUserPage.TabIndex = 11;
            btnGoToUserPage.Text = "Go To User Page";
            btnGoToUserPage.UseVisualStyleBackColor = true;
            btnGoToUserPage.Click += btnGoToUserPage_Click;
            // 
            // Purchasing
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1447, 742);
            Controls.Add(btnGoToUserPage);
            Controls.Add(dgvComponent);
            Controls.Add(gbxComponentDetails);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Purchasing";
            Text = "Purchasing";
            Load += Purchasing_Load;
            gbxComponentDetails.ResumeLayout(false);
            gbxComponentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComponent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxComponentDetails;
        private System.Windows.Forms.Label lblComponentDefinition;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxLeadTime;
        private System.Windows.Forms.TextBox tbxMinimumOrderQuantity;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxComponentDefinition;
        private System.Windows.Forms.Label lblLeadTime;
        private System.Windows.Forms.Label lblMinimumOrderQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.DataGridView dgvComponent;
        private System.Windows.Forms.TextBox tbxComponentCode;
        private System.Windows.Forms.Label lblComponentCode;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Button btnGoToUserPage;
    }
}