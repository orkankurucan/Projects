namespace WebFormsUI
{
    partial class Roles
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
            dgvRoles = new System.Windows.Forms.DataGridView();
            gbxRoles = new System.Windows.Forms.GroupBox();
            btnDelete = new System.Windows.Forms.Button();
            tbxRoleName = new System.Windows.Forms.TextBox();
            btnUpdate = new System.Windows.Forms.Button();
            lblRoleName = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnGoToUserPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            gbxRoles.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRoles
            // 
            dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new System.Drawing.Point(16, 15);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.ReadOnly = true;
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.Size = new System.Drawing.Size(757, 259);
            dgvRoles.TabIndex = 0;
            dgvRoles.CellClick += dgvRoles_CellClick;
            // 
            // gbxRoles
            // 
            gbxRoles.Controls.Add(btnDelete);
            gbxRoles.Controls.Add(tbxRoleName);
            gbxRoles.Controls.Add(btnUpdate);
            gbxRoles.Controls.Add(lblRoleName);
            gbxRoles.Controls.Add(btnAdd);
            gbxRoles.Location = new System.Drawing.Point(30, 284);
            gbxRoles.Name = "gbxRoles";
            gbxRoles.Size = new System.Drawing.Size(394, 154);
            gbxRoles.TabIndex = 1;
            gbxRoles.TabStop = false;
            gbxRoles.Text = "Role Info";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(255, 88);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tbxRoleName
            // 
            tbxRoleName.Location = new System.Drawing.Point(156, 35);
            tbxRoleName.Name = "tbxRoleName";
            tbxRoleName.Size = new System.Drawing.Size(125, 27);
            tbxRoleName.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(135, 88);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Location = new System.Drawing.Point(18, 42);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new System.Drawing.Size(83, 20);
            lblRoleName.TabIndex = 1;
            lblRoleName.Text = "Role Name";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(18, 88);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGoToUserPage
            // 
            btnGoToUserPage.Location = new System.Drawing.Point(443, 326);
            btnGoToUserPage.Name = "btnGoToUserPage";
            btnGoToUserPage.Size = new System.Drawing.Size(94, 75);
            btnGoToUserPage.TabIndex = 4;
            btnGoToUserPage.Text = "Go To User Page";
            btnGoToUserPage.UseVisualStyleBackColor = true;
            btnGoToUserPage.Click += btnGoToUserPage_Click;
            // 
            // Roles
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnGoToUserPage);
            Controls.Add(gbxRoles);
            Controls.Add(dgvRoles);
            Name = "Roles";
            Text = "Role";
            Load += Role_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            gbxRoles.ResumeLayout(false);
            gbxRoles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.GroupBox gbxRoles;
        private System.Windows.Forms.TextBox tbxRoleName;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGoToUserPage;
    }
}