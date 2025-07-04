namespace WebFormsUI
{
    partial class Screen
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
            dgvScreen = new System.Windows.Forms.DataGridView();
            gbxCreateScreen = new System.Windows.Forms.GroupBox();
            btnDelete = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            tbxScreenName = new System.Windows.Forms.TextBox();
            btnEdit = new System.Windows.Forms.Button();
            lblScreenName = new System.Windows.Forms.Label();
            btnGoToUserPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvScreen).BeginInit();
            gbxCreateScreen.SuspendLayout();
            SuspendLayout();
            // 
            // dgvScreen
            // 
            dgvScreen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScreen.Location = new System.Drawing.Point(16, 7);
            dgvScreen.Name = "dgvScreen";
            dgvScreen.RowHeadersWidth = 51;
            dgvScreen.Size = new System.Drawing.Size(718, 205);
            dgvScreen.TabIndex = 0;
            dgvScreen.CellClick += dgvScreen_CellClick;
            // 
            // gbxCreateScreen
            // 
            gbxCreateScreen.Controls.Add(btnDelete);
            gbxCreateScreen.Controls.Add(btnCreate);
            gbxCreateScreen.Controls.Add(tbxScreenName);
            gbxCreateScreen.Controls.Add(btnEdit);
            gbxCreateScreen.Controls.Add(lblScreenName);
            gbxCreateScreen.Location = new System.Drawing.Point(29, 218);
            gbxCreateScreen.Name = "gbxCreateScreen";
            gbxCreateScreen.Size = new System.Drawing.Size(315, 220);
            gbxCreateScreen.TabIndex = 1;
            gbxCreateScreen.TabStop = false;
            gbxCreateScreen.Text = "Create Screen";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(18, 163);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(185, 107);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 85);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // tbxScreenName
            // 
            tbxScreenName.Location = new System.Drawing.Point(154, 47);
            tbxScreenName.Name = "tbxScreenName";
            tbxScreenName.Size = new System.Drawing.Size(125, 27);
            tbxScreenName.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(18, 107);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblScreenName
            // 
            lblScreenName.AutoSize = true;
            lblScreenName.Location = new System.Drawing.Point(18, 54);
            lblScreenName.Name = "lblScreenName";
            lblScreenName.Size = new System.Drawing.Size(97, 20);
            lblScreenName.TabIndex = 0;
            lblScreenName.Text = "Screen Name";
            // 
            // btnGoToUserPage
            // 
            btnGoToUserPage.Location = new System.Drawing.Point(378, 325);
            btnGoToUserPage.Name = "btnGoToUserPage";
            btnGoToUserPage.Size = new System.Drawing.Size(94, 85);
            btnGoToUserPage.TabIndex = 5;
            btnGoToUserPage.Text = "Go To User Page";
            btnGoToUserPage.UseVisualStyleBackColor = true;
            btnGoToUserPage.Click += btnGoToUserPage_Click;
            // 
            // Screen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnGoToUserPage);
            Controls.Add(gbxCreateScreen);
            Controls.Add(dgvScreen);
            Name = "Screen";
            Text = "Screen";
            Load += Screen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvScreen).EndInit();
            gbxCreateScreen.ResumeLayout(false);
            gbxCreateScreen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScreen;
        private System.Windows.Forms.GroupBox gbxCreateScreen;
        private System.Windows.Forms.Label lblScreenName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbxScreenName;
        private System.Windows.Forms.Button btnGoToUserPage;
    }
}