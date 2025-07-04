namespace WebFormsUI
{
    partial class Departments
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
            dgvDepartment = new System.Windows.Forms.DataGridView();
            gbxDepartment = new System.Windows.Forms.GroupBox();
            tbxDepartmentName = new System.Windows.Forms.TextBox();
            tbxDepartmentId = new System.Windows.Forms.TextBox();
            lblDepartmentName = new System.Windows.Forms.Label();
            lblDepartmentID = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnGoToUserPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            gbxDepartment.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDepartment
            // 
            dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Location = new System.Drawing.Point(13, 8);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.RowHeadersWidth = 51;
            dgvDepartment.Size = new System.Drawing.Size(765, 268);
            dgvDepartment.TabIndex = 0;
            dgvDepartment.CellClick += dgvDepartment_CellClick;
            dgvDepartment.CellContentClick += dgvDepartment_CellContentClick;
            // 
            // gbxDepartment
            // 
            gbxDepartment.Controls.Add(tbxDepartmentName);
            gbxDepartment.Controls.Add(tbxDepartmentId);
            gbxDepartment.Controls.Add(lblDepartmentName);
            gbxDepartment.Controls.Add(lblDepartmentID);
            gbxDepartment.Location = new System.Drawing.Point(17, 290);
            gbxDepartment.Name = "gbxDepartment";
            gbxDepartment.Size = new System.Drawing.Size(340, 148);
            gbxDepartment.TabIndex = 1;
            gbxDepartment.TabStop = false;
            gbxDepartment.Text = "Department Info";
            // 
            // tbxDepartmentName
            // 
            tbxDepartmentName.Location = new System.Drawing.Point(189, 74);
            tbxDepartmentName.Name = "tbxDepartmentName";
            tbxDepartmentName.Size = new System.Drawing.Size(125, 27);
            tbxDepartmentName.TabIndex = 3;
            // 
            // tbxDepartmentId
            // 
            tbxDepartmentId.Location = new System.Drawing.Point(189, 33);
            tbxDepartmentId.Name = "tbxDepartmentId";
            tbxDepartmentId.ReadOnly = true;
            tbxDepartmentId.Size = new System.Drawing.Size(125, 27);
            tbxDepartmentId.TabIndex = 2;
            // 
            // lblDepartmentName
            // 
            lblDepartmentName.AutoSize = true;
            lblDepartmentName.Location = new System.Drawing.Point(19, 81);
            lblDepartmentName.Name = "lblDepartmentName";
            lblDepartmentName.Size = new System.Drawing.Size(133, 20);
            lblDepartmentName.TabIndex = 1;
            lblDepartmentName.Text = "Department Name";
            // 
            // lblDepartmentID
            // 
            lblDepartmentID.AutoSize = true;
            lblDepartmentID.Location = new System.Drawing.Point(19, 40);
            lblDepartmentID.Name = "lblDepartmentID";
            lblDepartmentID.Size = new System.Drawing.Size(108, 20);
            lblDepartmentID.TabIndex = 0;
            lblDepartmentID.Text = "Department ID";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(398, 309);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(398, 362);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(398, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGoToUserPage
            // 
            btnGoToUserPage.Location = new System.Drawing.Point(526, 409);
            btnGoToUserPage.Name = "btnGoToUserPage";
            btnGoToUserPage.Size = new System.Drawing.Size(135, 29);
            btnGoToUserPage.TabIndex = 5;
            btnGoToUserPage.Text = "Go To User Page";
            btnGoToUserPage.UseVisualStyleBackColor = true;
            btnGoToUserPage.Click += btnGoToUserPage_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnGoToUserPage);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(gbxDepartment);
            Controls.Add(dgvDepartment);
            Name = "Departments";
            Text = "Departments";
            Load += Departments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            gbxDepartment.ResumeLayout(false);
            gbxDepartment.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.GroupBox gbxDepartment;
        private System.Windows.Forms.TextBox tbxDepartmentName;
        private System.Windows.Forms.TextBox tbxDepartmentId;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGoToUserPage;
    }
}