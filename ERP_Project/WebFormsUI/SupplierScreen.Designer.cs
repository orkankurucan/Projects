namespace WebFormsUI
{
    partial class SupplierScreen
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
            dgvSupplier = new System.Windows.Forms.DataGridView();
            gbxCreateSupplier = new System.Windows.Forms.GroupBox();
            lblCountry = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            lblPostCode = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            tbxCountry = new System.Windows.Forms.TextBox();
            tbxCity = new System.Windows.Forms.TextBox();
            tbxPostCode = new System.Windows.Forms.TextBox();
            tbxSupplierAddress = new System.Windows.Forms.TextBox();
            tbxSupplierName = new System.Windows.Forms.TextBox();
            lblSupplierAddress = new System.Windows.Forms.Label();
            lblSupplierName = new System.Windows.Forms.Label();
            btnGoToUserPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            gbxCreateSupplier.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSupplier
            // 
            dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new System.Drawing.Point(11, 16);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.Size = new System.Drawing.Size(748, 188);
            dgvSupplier.TabIndex = 0;
            dgvSupplier.CellClick += dgvSupplier_CellClick;
            dgvSupplier.SelectionChanged += dgvSupplier_SelectionChanged;
            // 
            // gbxCreateSupplier
            // 
            gbxCreateSupplier.Controls.Add(lblCountry);
            gbxCreateSupplier.Controls.Add(lblCity);
            gbxCreateSupplier.Controls.Add(lblPostCode);
            gbxCreateSupplier.Controls.Add(btnDelete);
            gbxCreateSupplier.Controls.Add(btnEdit);
            gbxCreateSupplier.Controls.Add(btnAdd);
            gbxCreateSupplier.Controls.Add(tbxCountry);
            gbxCreateSupplier.Controls.Add(tbxCity);
            gbxCreateSupplier.Controls.Add(tbxPostCode);
            gbxCreateSupplier.Controls.Add(tbxSupplierAddress);
            gbxCreateSupplier.Controls.Add(tbxSupplierName);
            gbxCreateSupplier.Controls.Add(lblSupplierAddress);
            gbxCreateSupplier.Controls.Add(lblSupplierName);
            gbxCreateSupplier.Location = new System.Drawing.Point(17, 219);
            gbxCreateSupplier.Name = "gbxCreateSupplier";
            gbxCreateSupplier.Size = new System.Drawing.Size(555, 219);
            gbxCreateSupplier.TabIndex = 1;
            gbxCreateSupplier.TabStop = false;
            gbxCreateSupplier.Text = "Create Supplier";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new System.Drawing.Point(20, 193);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new System.Drawing.Size(60, 20);
            lblCountry.TabIndex = 12;
            lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new System.Drawing.Point(20, 149);
            lblCity.Name = "lblCity";
            lblCity.Size = new System.Drawing.Size(34, 20);
            lblCity.TabIndex = 11;
            lblCity.Text = "City";
            // 
            // lblPostCode
            // 
            lblPostCode.AutoSize = true;
            lblPostCode.Location = new System.Drawing.Point(20, 116);
            lblPostCode.Name = "lblPostCode";
            lblPostCode.Size = new System.Drawing.Size(75, 20);
            lblPostCode.TabIndex = 10;
            lblPostCode.Text = "Post Code";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(357, 109);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(357, 74);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(94, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(357, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxCountry
            // 
            tbxCountry.Location = new System.Drawing.Point(182, 186);
            tbxCountry.Name = "tbxCountry";
            tbxCountry.Size = new System.Drawing.Size(125, 27);
            tbxCountry.TabIndex = 6;
            // 
            // tbxCity
            // 
            tbxCity.Location = new System.Drawing.Point(182, 142);
            tbxCity.Name = "tbxCity";
            tbxCity.Size = new System.Drawing.Size(125, 27);
            tbxCity.TabIndex = 5;
            // 
            // tbxPostCode
            // 
            tbxPostCode.Location = new System.Drawing.Point(182, 109);
            tbxPostCode.Name = "tbxPostCode";
            tbxPostCode.Size = new System.Drawing.Size(125, 27);
            tbxPostCode.TabIndex = 4;
            // 
            // tbxSupplierAddress
            // 
            tbxSupplierAddress.Location = new System.Drawing.Point(182, 76);
            tbxSupplierAddress.Name = "tbxSupplierAddress";
            tbxSupplierAddress.Size = new System.Drawing.Size(125, 27);
            tbxSupplierAddress.TabIndex = 3;
            // 
            // tbxSupplierName
            // 
            tbxSupplierName.Location = new System.Drawing.Point(182, 39);
            tbxSupplierName.Name = "tbxSupplierName";
            tbxSupplierName.Size = new System.Drawing.Size(125, 27);
            tbxSupplierName.TabIndex = 2;
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.Location = new System.Drawing.Point(20, 74);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new System.Drawing.Size(130, 20);
            lblSupplierAddress.TabIndex = 1;
            lblSupplierAddress.Text = "Suppplier Address";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new System.Drawing.Point(16, 39);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new System.Drawing.Size(108, 20);
            lblSupplierName.TabIndex = 0;
            lblSupplierName.Text = "Supplier Name";
            // 
            // btnGoToUserPage
            // 
            btnGoToUserPage.Location = new System.Drawing.Point(646, 328);
            btnGoToUserPage.Name = "btnGoToUserPage";
            btnGoToUserPage.Size = new System.Drawing.Size(94, 62);
            btnGoToUserPage.TabIndex = 14;
            btnGoToUserPage.Text = "Go To User Page";
            btnGoToUserPage.UseVisualStyleBackColor = true;
            btnGoToUserPage.Click += btnGoToUserPage_Click;
            // 
            // SupplierScreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnGoToUserPage);
            Controls.Add(gbxCreateSupplier);
            Controls.Add(dgvSupplier);
            Name = "SupplierScreen";
            Text = "Supplier";
            Load += Supplier_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            gbxCreateSupplier.ResumeLayout(false);
            gbxCreateSupplier.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.GroupBox gbxCreateSupplier;
        private System.Windows.Forms.TextBox tbxPostCode;
        private System.Windows.Forms.TextBox tbxSupplierAddress;
        private System.Windows.Forms.TextBox tbxSupplierName;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Button btnGoToUserPage;
    }
}