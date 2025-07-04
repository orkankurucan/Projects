namespace WebFormsUI
{
    partial class Inventory
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
            dgvInventory = new System.Windows.Forms.DataGridView();
            gbxInventory = new System.Windows.Forms.GroupBox();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            tbxQuantity = new System.Windows.Forms.TextBox();
            lblQuantity = new System.Windows.Forms.Label();
            tbxCode = new System.Windows.Forms.TextBox();
            lblCode = new System.Windows.Forms.Label();
            btnGoToUserPage = new System.Windows.Forms.Button();
            btnAddComponents = new System.Windows.Forms.Button();
            btnAddProducts = new System.Windows.Forms.Button();
            btnShipment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            gbxInventory.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new System.Drawing.Point(12, 12);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new System.Drawing.Size(776, 239);
            dgvInventory.TabIndex = 0;
            dgvInventory.AutoSizeColumnsModeChanged += dgvInventory_AutoSizeColumnsModeChanged;
            dgvInventory.CellClick += dgvInventory_CellClick;
            // 
            // gbxInventory
            // 
            gbxInventory.Controls.Add(btnDelete);
            gbxInventory.Controls.Add(btnEdit);
            gbxInventory.Controls.Add(btnAdd);
            gbxInventory.Controls.Add(tbxQuantity);
            gbxInventory.Controls.Add(lblQuantity);
            gbxInventory.Controls.Add(tbxCode);
            gbxInventory.Controls.Add(lblCode);
            gbxInventory.Location = new System.Drawing.Point(25, 267);
            gbxInventory.Name = "gbxInventory";
            gbxInventory.Size = new System.Drawing.Size(335, 171);
            gbxInventory.TabIndex = 1;
            gbxInventory.TabStop = false;
            gbxInventory.Text = "Inventory";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(235, 124);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(134, 124);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(27, 121);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxQuantity
            // 
            tbxQuantity.Location = new System.Drawing.Point(114, 80);
            tbxQuantity.Name = "tbxQuantity";
            tbxQuantity.Size = new System.Drawing.Size(125, 27);
            tbxQuantity.TabIndex = 1;
            tbxQuantity.KeyPress += tbxQuantity_KeyPress;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new System.Drawing.Point(24, 76);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(65, 20);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            // 
            // tbxCode
            // 
            tbxCode.Location = new System.Drawing.Point(109, 35);
            tbxCode.Name = "tbxCode";
            tbxCode.Size = new System.Drawing.Size(125, 27);
            tbxCode.TabIndex = 0;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new System.Drawing.Point(24, 42);
            lblCode.Name = "lblCode";
            lblCode.Size = new System.Drawing.Size(44, 20);
            lblCode.TabIndex = 5;
            lblCode.Text = "Code";
            // 
            // btnGoToUserPage
            // 
            btnGoToUserPage.Location = new System.Drawing.Point(386, 381);
            btnGoToUserPage.Name = "btnGoToUserPage";
            btnGoToUserPage.Size = new System.Drawing.Size(115, 49);
            btnGoToUserPage.TabIndex = 7;
            btnGoToUserPage.Text = "Go To User Page";
            btnGoToUserPage.UseVisualStyleBackColor = true;
            btnGoToUserPage.Click += btnGoToUserPage_Click;
            // 
            // btnAddComponents
            // 
            btnAddComponents.Location = new System.Drawing.Point(384, 280);
            btnAddComponents.Name = "btnAddComponents";
            btnAddComponents.Size = new System.Drawing.Size(103, 83);
            btnAddComponents.TabIndex = 8;
            btnAddComponents.Text = "Add Arrived Components";
            btnAddComponents.UseVisualStyleBackColor = true;
            btnAddComponents.Click += btnAddComponents_Click;
            // 
            // btnAddProducts
            // 
            btnAddProducts.Location = new System.Drawing.Point(505, 280);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new System.Drawing.Size(119, 83);
            btnAddProducts.TabIndex = 9;
            btnAddProducts.Text = "Receive Manufactured Products";
            btnAddProducts.UseVisualStyleBackColor = true;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // btnShipment
            // 
            btnShipment.Location = new System.Drawing.Point(643, 285);
            btnShipment.Name = "btnShipment";
            btnShipment.Size = new System.Drawing.Size(94, 64);
            btnShipment.TabIndex = 10;
            btnShipment.Text = "Make Shipment";
            btnShipment.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnShipment);
            Controls.Add(btnAddProducts);
            Controls.Add(btnAddComponents);
            Controls.Add(btnGoToUserPage);
            Controls.Add(gbxInventory);
            Controls.Add(dgvInventory);
            Name = "Inventory";
            Text = "Inventory";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            gbxInventory.ResumeLayout(false);
            gbxInventory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.GroupBox gbxInventory;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Button btnGoToUserPage;
        private System.Windows.Forms.Button btnAddComponents;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnShipment;
    }
}