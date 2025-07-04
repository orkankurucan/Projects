namespace WebFormsUI
{
    partial class Method
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
            gbxCreateMachine = new System.Windows.Forms.GroupBox();
            btnGoToUserPage = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            tbxMachineCapacity = new System.Windows.Forms.TextBox();
            tbxMachineProcess = new System.Windows.Forms.TextBox();
            tbxMachineName = new System.Windows.Forms.TextBox();
            lblMachineCapacity = new System.Windows.Forms.Label();
            lblMachineProcess = new System.Windows.Forms.Label();
            lblMachineName = new System.Windows.Forms.Label();
            dgvMachine = new System.Windows.Forms.DataGridView();
            gbxCreateMachine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMachine).BeginInit();
            SuspendLayout();
            // 
            // gbxCreateMachine
            // 
            gbxCreateMachine.Controls.Add(btnGoToUserPage);
            gbxCreateMachine.Controls.Add(btnDelete);
            gbxCreateMachine.Controls.Add(btnEdit);
            gbxCreateMachine.Controls.Add(btnSave);
            gbxCreateMachine.Controls.Add(tbxMachineCapacity);
            gbxCreateMachine.Controls.Add(tbxMachineProcess);
            gbxCreateMachine.Controls.Add(tbxMachineName);
            gbxCreateMachine.Controls.Add(lblMachineCapacity);
            gbxCreateMachine.Controls.Add(lblMachineProcess);
            gbxCreateMachine.Controls.Add(lblMachineName);
            gbxCreateMachine.Location = new System.Drawing.Point(12, 303);
            gbxCreateMachine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxCreateMachine.Name = "gbxCreateMachine";
            gbxCreateMachine.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxCreateMachine.Size = new System.Drawing.Size(648, 246);
            gbxCreateMachine.TabIndex = 0;
            gbxCreateMachine.TabStop = false;
            gbxCreateMachine.Text = "Create Machine";
            // 
            // btnGoToUserPage
            // 
            btnGoToUserPage.Location = new System.Drawing.Point(451, 125);
            btnGoToUserPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGoToUserPage.Name = "btnGoToUserPage";
            btnGoToUserPage.Size = new System.Drawing.Size(178, 81);
            btnGoToUserPage.TabIndex = 10;
            btnGoToUserPage.Text = "Go To User Page";
            btnGoToUserPage.UseVisualStyleBackColor = true;
            btnGoToUserPage.Click += btnGoToUserPage_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(297, 156);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(117, 65);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(155, 156);
            btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(117, 65);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(13, 156);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(117, 65);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbxMachineCapacity
            // 
            tbxMachineCapacity.Location = new System.Drawing.Point(172, 108);
            tbxMachineCapacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxMachineCapacity.Name = "tbxMachineCapacity";
            tbxMachineCapacity.Size = new System.Drawing.Size(100, 27);
            tbxMachineCapacity.TabIndex = 2;
            tbxMachineCapacity.KeyPress += tbxMachineCapacity_KeyPress;
            // 
            // tbxMachineProcess
            // 
            tbxMachineProcess.Location = new System.Drawing.Point(172, 73);
            tbxMachineProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxMachineProcess.Name = "tbxMachineProcess";
            tbxMachineProcess.Size = new System.Drawing.Size(100, 27);
            tbxMachineProcess.TabIndex = 1;
            // 
            // tbxMachineName
            // 
            tbxMachineName.Location = new System.Drawing.Point(172, 38);
            tbxMachineName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxMachineName.Name = "tbxMachineName";
            tbxMachineName.Size = new System.Drawing.Size(100, 27);
            tbxMachineName.TabIndex = 0;
            // 
            // lblMachineCapacity
            // 
            lblMachineCapacity.AutoSize = true;
            lblMachineCapacity.Location = new System.Drawing.Point(13, 108);
            lblMachineCapacity.Name = "lblMachineCapacity";
            lblMachineCapacity.Size = new System.Drawing.Size(126, 20);
            lblMachineCapacity.TabIndex = 8;
            lblMachineCapacity.Text = "Machine Capacity";
            // 
            // lblMachineProcess
            // 
            lblMachineProcess.AutoSize = true;
            lblMachineProcess.Location = new System.Drawing.Point(13, 77);
            lblMachineProcess.Name = "lblMachineProcess";
            lblMachineProcess.Size = new System.Drawing.Size(118, 20);
            lblMachineProcess.TabIndex = 7;
            lblMachineProcess.Text = "Machine Process";
            // 
            // lblMachineName
            // 
            lblMachineName.AutoSize = true;
            lblMachineName.Location = new System.Drawing.Point(13, 45);
            lblMachineName.Name = "lblMachineName";
            lblMachineName.Size = new System.Drawing.Size(109, 20);
            lblMachineName.TabIndex = 6;
            lblMachineName.Text = "Machine Name";
            // 
            // dgvMachine
            // 
            dgvMachine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMachine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMachine.Location = new System.Drawing.Point(12, 10);
            dgvMachine.Name = "dgvMachine";
            dgvMachine.RowHeadersWidth = 51;
            dgvMachine.Size = new System.Drawing.Size(759, 286);
            dgvMachine.TabIndex = 1;
            dgvMachine.CellClick += dgvMachine_CellClick;
            // 
            // Method
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(dgvMachine);
            Controls.Add(gbxCreateMachine);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Method";
            Text = "Method";
            Load += Method_Load;
            gbxCreateMachine.ResumeLayout(false);
            gbxCreateMachine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMachine).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCreateMachine;
        private System.Windows.Forms.Label lblDateOfPurchase;
        private System.Windows.Forms.Label lblMachineSupplier;
        private System.Windows.Forms.Label lblMachineProcess;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblMachineId;
        private System.Windows.Forms.TextBox tbxMaintenanceFrequency;
        private System.Windows.Forms.TextBox tbxMachineOrigin;
        private System.Windows.Forms.TextBox tbxDateOfPurchase;
        private System.Windows.Forms.TextBox tbxMachineSupplier;
        private System.Windows.Forms.TextBox tbxMachineProcess;
        private System.Windows.Forms.TextBox tbxMachineName;
        private System.Windows.Forms.TextBox tbxMachineId;
        private System.Windows.Forms.Label lblMachineCapacity;
        private System.Windows.Forms.Label lblMaintenanceFrequency;
        private System.Windows.Forms.Label lblMachineOrigin;
        private System.Windows.Forms.TextBox tbxMachineCapacity;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvMachine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxIdOfTheMachine;
        private System.Windows.Forms.TextBox tbxComponentId;
        private System.Windows.Forms.Label lblIdOfTheMachine;
        private System.Windows.Forms.Label lblComponentId;
        private System.Windows.Forms.Button btnGoToUserPage;
    }
}