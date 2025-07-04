namespace WebFormsUI
{
    partial class ComponentMachineAllocation
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
            dgvComponentMachine = new System.Windows.Forms.DataGridView();
            lblProductCode = new System.Windows.Forms.Label();
            cbxProducts = new System.Windows.Forms.ComboBox();
            lblProductDefinition = new System.Windows.Forms.Label();
            tbxProductDefinition = new System.Windows.Forms.TextBox();
            lblComponentCode = new System.Windows.Forms.Label();
            cbxComponents = new System.Windows.Forms.ComboBox();
            lblComponentDefinition = new System.Windows.Forms.Label();
            tbxComponentDefinition = new System.Windows.Forms.TextBox();
            cbxMachines = new System.Windows.Forms.ComboBox();
            lblMachineName = new System.Windows.Forms.Label();
            tbxSubCode = new System.Windows.Forms.TextBox();
            lblSubCode = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUserPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvComponentMachine).BeginInit();
            SuspendLayout();
            // 
            // dgvComponentMachine
            // 
            dgvComponentMachine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvComponentMachine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComponentMachine.Location = new System.Drawing.Point(15, 10);
            dgvComponentMachine.Name = "dgvComponentMachine";
            dgvComponentMachine.RowHeadersWidth = 51;
            dgvComponentMachine.Size = new System.Drawing.Size(761, 188);
            dgvComponentMachine.TabIndex = 0;
            dgvComponentMachine.CellClick += dgvComponentMachine_CellClick;
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new System.Drawing.Point(32, 246);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new System.Drawing.Size(99, 20);
            lblProductCode.TabIndex = 11;
            lblProductCode.Text = "Product Code";
            // 
            // cbxProducts
            // 
            cbxProducts.FormattingEnabled = true;
            cbxProducts.Location = new System.Drawing.Point(213, 238);
            cbxProducts.Name = "cbxProducts";
            cbxProducts.Size = new System.Drawing.Size(151, 28);
            cbxProducts.TabIndex = 0;
            cbxProducts.SelectedIndexChanged += cbxProducts_SelectedIndexChanged;
            // 
            // lblProductDefinition
            // 
            lblProductDefinition.AutoSize = true;
            lblProductDefinition.Location = new System.Drawing.Point(32, 277);
            lblProductDefinition.Name = "lblProductDefinition";
            lblProductDefinition.Size = new System.Drawing.Size(130, 20);
            lblProductDefinition.TabIndex = 12;
            lblProductDefinition.Text = "Product Definition";
            // 
            // tbxProductDefinition
            // 
            tbxProductDefinition.Location = new System.Drawing.Point(213, 274);
            tbxProductDefinition.Name = "tbxProductDefinition";
            tbxProductDefinition.ReadOnly = true;
            tbxProductDefinition.Size = new System.Drawing.Size(125, 27);
            tbxProductDefinition.TabIndex = 1;
            // 
            // lblComponentCode
            // 
            lblComponentCode.AutoSize = true;
            lblComponentCode.Location = new System.Drawing.Point(32, 314);
            lblComponentCode.Name = "lblComponentCode";
            lblComponentCode.Size = new System.Drawing.Size(122, 20);
            lblComponentCode.TabIndex = 13;
            lblComponentCode.Text = "ComponentCode";
            // 
            // cbxComponents
            // 
            cbxComponents.FormattingEnabled = true;
            cbxComponents.Location = new System.Drawing.Point(213, 310);
            cbxComponents.Name = "cbxComponents";
            cbxComponents.Size = new System.Drawing.Size(151, 28);
            cbxComponents.TabIndex = 2;
            cbxComponents.SelectedIndexChanged += cbxComponents_SelectedIndexChanged;
            // 
            // lblComponentDefinition
            // 
            lblComponentDefinition.AutoSize = true;
            lblComponentDefinition.Location = new System.Drawing.Point(32, 351);
            lblComponentDefinition.Name = "lblComponentDefinition";
            lblComponentDefinition.Size = new System.Drawing.Size(153, 20);
            lblComponentDefinition.TabIndex = 14;
            lblComponentDefinition.Text = "ComponentDefinition";
            // 
            // tbxComponentDefinition
            // 
            tbxComponentDefinition.Location = new System.Drawing.Point(213, 348);
            tbxComponentDefinition.Name = "tbxComponentDefinition";
            tbxComponentDefinition.ReadOnly = true;
            tbxComponentDefinition.Size = new System.Drawing.Size(125, 27);
            tbxComponentDefinition.TabIndex = 3;
            // 
            // cbxMachines
            // 
            cbxMachines.FormattingEnabled = true;
            cbxMachines.Location = new System.Drawing.Point(606, 230);
            cbxMachines.Name = "cbxMachines";
            cbxMachines.Size = new System.Drawing.Size(151, 28);
            cbxMachines.TabIndex = 4;
            cbxMachines.SelectedIndexChanged += cbxMachines_SelectedIndexChanged;
            // 
            // lblMachineName
            // 
            lblMachineName.AutoSize = true;
            lblMachineName.Location = new System.Drawing.Point(460, 238);
            lblMachineName.Name = "lblMachineName";
            lblMachineName.Size = new System.Drawing.Size(109, 20);
            lblMachineName.TabIndex = 15;
            lblMachineName.Text = "Machine Name";
            // 
            // tbxSubCode
            // 
            tbxSubCode.Location = new System.Drawing.Point(632, 274);
            tbxSubCode.Name = "tbxSubCode";
            tbxSubCode.Size = new System.Drawing.Size(125, 27);
            tbxSubCode.TabIndex = 7;
            // 
            // lblSubCode
            // 
            lblSubCode.AutoSize = true;
            lblSubCode.Location = new System.Drawing.Point(486, 277);
            lblSubCode.Name = "lblSubCode";
            lblSubCode.Size = new System.Drawing.Size(75, 20);
            lblSubCode.TabIndex = 18;
            lblSubCode.Text = "Sub-Code";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(92, 406);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(213, 409);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(94, 29);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(323, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUserPage
            // 
            btnUserPage.Location = new System.Drawing.Point(668, 383);
            btnUserPage.Name = "btnUserPage";
            btnUserPage.Size = new System.Drawing.Size(108, 52);
            btnUserPage.TabIndex = 20;
            btnUserPage.Text = "Go To User Page";
            btnUserPage.UseVisualStyleBackColor = true;
            btnUserPage.Click += btnUserPage_Click;
            // 
            // ComponentMachineAllocation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnUserPage);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lblSubCode);
            Controls.Add(tbxSubCode);
            Controls.Add(cbxMachines);
            Controls.Add(lblMachineName);
            Controls.Add(tbxComponentDefinition);
            Controls.Add(lblComponentDefinition);
            Controls.Add(cbxComponents);
            Controls.Add(lblComponentCode);
            Controls.Add(tbxProductDefinition);
            Controls.Add(lblProductDefinition);
            Controls.Add(cbxProducts);
            Controls.Add(lblProductCode);
            Controls.Add(dgvComponentMachine);
            Name = "ComponentMachineAllocation";
            Text = "ComponentMachineAllocation";
            Load += ComponentMachineAllocation_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComponentMachine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComponentMachine;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.Label lblProductDefinition;
        private System.Windows.Forms.TextBox tbxProductDefinition;
        private System.Windows.Forms.Label lblComponentCode;
        private System.Windows.Forms.ComboBox cbxComponents;
        private System.Windows.Forms.Label lblComponentDefinition;
        private System.Windows.Forms.TextBox tbxComponentDefinition;
        private System.Windows.Forms.ComboBox cbxMachines;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.TextBox tbxSubCode;
        private System.Windows.Forms.Label lblSubCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUserPage;
    }
}