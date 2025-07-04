namespace WebFormsUI
{
    partial class Engineering
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
            gbxCreateProduct = new System.Windows.Forms.GroupBox();
            cbxComponents = new System.Windows.Forms.ComboBox();
            btnGoToUserPage = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            tbxQuantity = new System.Windows.Forms.TextBox();
            lblQuantity = new System.Windows.Forms.Label();
            tbxVersion = new System.Windows.Forms.TextBox();
            lblVersion = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            tbxComponentDefinition = new System.Windows.Forms.TextBox();
            tbxProductDefinition = new System.Windows.Forms.TextBox();
            tbxProductCode = new System.Windows.Forms.TextBox();
            lblComponentDefinition = new System.Windows.Forms.Label();
            lblComponenCode = new System.Windows.Forms.Label();
            lblProductDefinition = new System.Windows.Forms.Label();
            lblProductCode = new System.Windows.Forms.Label();
            dgvProduct = new System.Windows.Forms.DataGridView();
            gbxCreateProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // gbxCreateProduct
            // 
            gbxCreateProduct.Controls.Add(cbxComponents);
            gbxCreateProduct.Controls.Add(btnGoToUserPage);
            gbxCreateProduct.Controls.Add(btnAdd);
            gbxCreateProduct.Controls.Add(tbxQuantity);
            gbxCreateProduct.Controls.Add(lblQuantity);
            gbxCreateProduct.Controls.Add(tbxVersion);
            gbxCreateProduct.Controls.Add(lblVersion);
            gbxCreateProduct.Controls.Add(btnDelete);
            gbxCreateProduct.Controls.Add(btnEdit);
            gbxCreateProduct.Controls.Add(tbxComponentDefinition);
            gbxCreateProduct.Controls.Add(tbxProductDefinition);
            gbxCreateProduct.Controls.Add(tbxProductCode);
            gbxCreateProduct.Controls.Add(lblComponentDefinition);
            gbxCreateProduct.Controls.Add(lblComponenCode);
            gbxCreateProduct.Controls.Add(lblProductDefinition);
            gbxCreateProduct.Controls.Add(lblProductCode);
            gbxCreateProduct.Location = new System.Drawing.Point(12, 15);
            gbxCreateProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxCreateProduct.Name = "gbxCreateProduct";
            gbxCreateProduct.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxCreateProduct.Size = new System.Drawing.Size(484, 532);
            gbxCreateProduct.TabIndex = 0;
            gbxCreateProduct.TabStop = false;
            gbxCreateProduct.Text = "Create Product";
            // 
            // cbxComponents
            // 
            cbxComponents.FormattingEnabled = true;
            cbxComponents.Location = new System.Drawing.Point(238, 188);
            cbxComponents.Name = "cbxComponents";
            cbxComponents.Size = new System.Drawing.Size(96, 28);
            cbxComponents.TabIndex = 3;
            cbxComponents.SelectedIndexChanged += cbxComponents_SelectedIndexChanged;
            // 
            // btnGoToUserPage
            // 
            btnGoToUserPage.Location = new System.Drawing.Point(313, 438);
            btnGoToUserPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGoToUserPage.Name = "btnGoToUserPage";
            btnGoToUserPage.Size = new System.Drawing.Size(116, 66);
            btnGoToUserPage.TabIndex = 16;
            btnGoToUserPage.Text = "Go To User Page";
            btnGoToUserPage.UseVisualStyleBackColor = true;
            btnGoToUserPage.Click += btnGoToUserPage_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(22, 354);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(116, 66);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxQuantity
            // 
            tbxQuantity.Location = new System.Drawing.Point(238, 286);
            tbxQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxQuantity.Name = "tbxQuantity";
            tbxQuantity.Size = new System.Drawing.Size(100, 27);
            tbxQuantity.TabIndex = 5;
            tbxQuantity.KeyPress += tbxQuantity_KeyPress;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new System.Drawing.Point(25, 288);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(65, 20);
            lblQuantity.TabIndex = 15;
            lblQuantity.Text = "Quantity";
            // 
            // tbxVersion
            // 
            tbxVersion.Location = new System.Drawing.Point(238, 142);
            tbxVersion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxVersion.Name = "tbxVersion";
            tbxVersion.Size = new System.Drawing.Size(100, 27);
            tbxVersion.TabIndex = 2;
            tbxVersion.KeyPress += tbxVersion_KeyPress;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new System.Drawing.Point(25, 144);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(57, 20);
            lblVersion.TabIndex = 12;
            lblVersion.Text = "Version";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(313, 354);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(116, 66);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(170, 354);
            btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(116, 66);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // tbxComponentDefinition
            // 
            tbxComponentDefinition.Location = new System.Drawing.Point(238, 242);
            tbxComponentDefinition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxComponentDefinition.Name = "tbxComponentDefinition";
            tbxComponentDefinition.Size = new System.Drawing.Size(100, 27);
            tbxComponentDefinition.TabIndex = 4;
            // 
            // tbxProductDefinition
            // 
            tbxProductDefinition.Location = new System.Drawing.Point(238, 106);
            tbxProductDefinition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxProductDefinition.Name = "tbxProductDefinition";
            tbxProductDefinition.Size = new System.Drawing.Size(100, 27);
            tbxProductDefinition.TabIndex = 1;
            // 
            // tbxProductCode
            // 
            tbxProductCode.Location = new System.Drawing.Point(238, 65);
            tbxProductCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxProductCode.Name = "tbxProductCode";
            tbxProductCode.Size = new System.Drawing.Size(100, 27);
            tbxProductCode.TabIndex = 0;
            tbxProductCode.TextChanged += tbxProductCode_TextChanged;
            // 
            // lblComponentDefinition
            // 
            lblComponentDefinition.AutoSize = true;
            lblComponentDefinition.Location = new System.Drawing.Point(22, 239);
            lblComponentDefinition.Name = "lblComponentDefinition";
            lblComponentDefinition.Size = new System.Drawing.Size(157, 20);
            lblComponentDefinition.TabIndex = 14;
            lblComponentDefinition.Text = "Component Definition";
            // 
            // lblComponenCode
            // 
            lblComponenCode.AutoSize = true;
            lblComponenCode.Location = new System.Drawing.Point(22, 196);
            lblComponenCode.Name = "lblComponenCode";
            lblComponenCode.Size = new System.Drawing.Size(126, 20);
            lblComponenCode.TabIndex = 13;
            lblComponenCode.Text = "Component Code";
            // 
            // lblProductDefinition
            // 
            lblProductDefinition.AutoSize = true;
            lblProductDefinition.Location = new System.Drawing.Point(22, 106);
            lblProductDefinition.Name = "lblProductDefinition";
            lblProductDefinition.Size = new System.Drawing.Size(130, 20);
            lblProductDefinition.TabIndex = 11;
            lblProductDefinition.Text = "Product Definition";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new System.Drawing.Point(22, 65);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new System.Drawing.Size(99, 20);
            lblProductCode.TabIndex = 10;
            lblProductCode.Text = "Product Code";
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new System.Drawing.Point(515, 25);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new System.Drawing.Size(960, 522);
            dgvProduct.TabIndex = 1;
            dgvProduct.AutoSizeColumnModeChanged += dgvProduct_AutoSizeColumnModeChanged;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // Engineering
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1487, 562);
            Controls.Add(dgvProduct);
            Controls.Add(gbxCreateProduct);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Engineering";
            Text = "Engineering";
            Load += Engineering_Load;
            gbxCreateProduct.ResumeLayout(false);
            gbxCreateProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCreateProduct;
        private System.Windows.Forms.Label lblComponentDefinition;
        private System.Windows.Forms.Label lblComponenCode;
        private System.Windows.Forms.Label lblProductDefinition;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox tbxProductDefinition;
        private System.Windows.Forms.TextBox tbxProductCode;
        private System.Windows.Forms.TextBox tbxComponentDefinition;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbxVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGoToUserPage;
        private System.Windows.Forms.ComboBox cbxComponents;
    }
}