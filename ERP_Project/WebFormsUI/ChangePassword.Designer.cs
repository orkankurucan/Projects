namespace WebFormsUI
{
    partial class ChangePassword
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
            lblNewPasseord = new System.Windows.Forms.Label();
            lblReEnterNewPassword = new System.Windows.Forms.Label();
            tbxEnterNewPassword = new System.Windows.Forms.TextBox();
            tbxReEnterNewPassword = new System.Windows.Forms.TextBox();
            btnConfirmNewPassword = new System.Windows.Forms.Button();
            gbxChangeMyPassword = new System.Windows.Forms.GroupBox();
            btnGoToUserPage = new System.Windows.Forms.Button();
            gbxChangeMyPassword.SuspendLayout();
            SuspendLayout();
            // 
            // lblNewPasseord
            // 
            lblNewPasseord.AutoSize = true;
            lblNewPasseord.Location = new System.Drawing.Point(51, 54);
            lblNewPasseord.Name = "lblNewPasseord";
            lblNewPasseord.Size = new System.Drawing.Size(142, 20);
            lblNewPasseord.TabIndex = 0;
            lblNewPasseord.Text = "Enter New Password";
            // 
            // lblReEnterNewPassword
            // 
            lblReEnterNewPassword.AutoSize = true;
            lblReEnterNewPassword.Location = new System.Drawing.Point(54, 96);
            lblReEnterNewPassword.Name = "lblReEnterNewPassword";
            lblReEnterNewPassword.Size = new System.Drawing.Size(165, 20);
            lblReEnterNewPassword.TabIndex = 1;
            lblReEnterNewPassword.Text = "Re-Enter New Password";
            // 
            // tbxEnterNewPassword
            // 
            tbxEnterNewPassword.Location = new System.Drawing.Point(230, 46);
            tbxEnterNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxEnterNewPassword.Name = "tbxEnterNewPassword";
            tbxEnterNewPassword.Size = new System.Drawing.Size(144, 27);
            tbxEnterNewPassword.TabIndex = 2;
            // 
            // tbxReEnterNewPassword
            // 
            tbxReEnterNewPassword.Location = new System.Drawing.Point(230, 92);
            tbxReEnterNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxReEnterNewPassword.Name = "tbxReEnterNewPassword";
            tbxReEnterNewPassword.Size = new System.Drawing.Size(144, 27);
            tbxReEnterNewPassword.TabIndex = 3;
            // 
            // btnConfirmNewPassword
            // 
            btnConfirmNewPassword.Location = new System.Drawing.Point(109, 150);
            btnConfirmNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnConfirmNewPassword.Name = "btnConfirmNewPassword";
            btnConfirmNewPassword.Size = new System.Drawing.Size(175, 55);
            btnConfirmNewPassword.TabIndex = 4;
            btnConfirmNewPassword.Text = "Confirm New Password";
            btnConfirmNewPassword.UseVisualStyleBackColor = true;
            btnConfirmNewPassword.Click += btnConfirmNewPassword_Click;
            // 
            // gbxChangeMyPassword
            // 
            gbxChangeMyPassword.Controls.Add(btnGoToUserPage);
            gbxChangeMyPassword.Controls.Add(tbxReEnterNewPassword);
            gbxChangeMyPassword.Controls.Add(btnConfirmNewPassword);
            gbxChangeMyPassword.Controls.Add(lblNewPasseord);
            gbxChangeMyPassword.Controls.Add(lblReEnterNewPassword);
            gbxChangeMyPassword.Controls.Add(tbxEnterNewPassword);
            gbxChangeMyPassword.Cursor = System.Windows.Forms.Cursors.SizeNS;
            gbxChangeMyPassword.Location = new System.Drawing.Point(12, 29);
            gbxChangeMyPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxChangeMyPassword.Name = "gbxChangeMyPassword";
            gbxChangeMyPassword.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxChangeMyPassword.Size = new System.Drawing.Size(539, 275);
            gbxChangeMyPassword.TabIndex = 5;
            gbxChangeMyPassword.TabStop = false;
            gbxChangeMyPassword.Text = "Change My Password";
            // 
            // btnGoToUserPage
            // 
            btnGoToUserPage.Location = new System.Drawing.Point(349, 150);
            btnGoToUserPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGoToUserPage.Name = "btnGoToUserPage";
            btnGoToUserPage.Size = new System.Drawing.Size(175, 55);
            btnGoToUserPage.TabIndex = 5;
            btnGoToUserPage.Text = "Go To User Page";
            btnGoToUserPage.UseVisualStyleBackColor = true;
            btnGoToUserPage.Click += btnGoToUserPage_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(gbxChangeMyPassword);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ChangePassword";
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            gbxChangeMyPassword.ResumeLayout(false);
            gbxChangeMyPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblNewPasseord;
        private System.Windows.Forms.Label lblReEnterNewPassword;
        private System.Windows.Forms.TextBox tbxEnterNewPassword;
        private System.Windows.Forms.TextBox tbxReEnterNewPassword;
        private System.Windows.Forms.Button btnConfirmNewPassword;
        private System.Windows.Forms.GroupBox gbxChangeMyPassword;
        private System.Windows.Forms.Button btnGoToUserPage;
    }
}