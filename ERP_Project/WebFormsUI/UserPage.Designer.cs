namespace WebFormsUI
{
    partial class UserPage
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
            cbxChooseScreen = new System.Windows.Forms.ComboBox();
            lblWelcome = new System.Windows.Forms.Label();
            lblDateTime = new System.Windows.Forms.Label();
            lblChooseScreen = new System.Windows.Forms.Label();
            btnGo = new System.Windows.Forms.Button();
            lblUser = new System.Windows.Forms.Label();
            lblDepartment = new System.Windows.Forms.Label();
            lblRole = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cbxChooseScreen
            // 
            cbxChooseScreen.FormattingEnabled = true;
            cbxChooseScreen.Location = new System.Drawing.Point(224, 253);
            cbxChooseScreen.Name = "cbxChooseScreen";
            cbxChooseScreen.Size = new System.Drawing.Size(228, 28);
            cbxChooseScreen.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new System.Drawing.Point(28, 23);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(75, 20);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome ";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new System.Drawing.Point(853, 33);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new System.Drawing.Size(107, 20);
            lblDateTime.TabIndex = 2;
            lblDateTime.Text = "Date and Time";
            // 
            // lblChooseScreen
            // 
            lblChooseScreen.AutoSize = true;
            lblChooseScreen.Location = new System.Drawing.Point(224, 202);
            lblChooseScreen.Name = "lblChooseScreen";
            lblChooseScreen.Size = new System.Drawing.Size(184, 20);
            lblChooseScreen.TabIndex = 3;
            lblChooseScreen.Text = "Please Choose The Screen ";
            // 
            // btnGo
            // 
            btnGo.Location = new System.Drawing.Point(293, 317);
            btnGo.Name = "btnGo";
            btnGo.Size = new System.Drawing.Size(94, 29);
            btnGo.TabIndex = 4;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new System.Drawing.Point(28, 74);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(140, 20);
            lblUser.TabIndex = 5;
            lblUser.Text = "Name and Surname";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new System.Drawing.Point(28, 109);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new System.Drawing.Size(89, 20);
            lblDepartment.TabIndex = 6;
            lblDepartment.Text = "Department";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new System.Drawing.Point(28, 142);
            lblRole.Name = "lblRole";
            lblRole.Size = new System.Drawing.Size(39, 20);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role";
            // 
            // UserPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 587);
            Controls.Add(lblRole);
            Controls.Add(lblDepartment);
            Controls.Add(lblUser);
            Controls.Add(btnGo);
            Controls.Add(lblChooseScreen);
            Controls.Add(lblDateTime);
            Controls.Add(lblWelcome);
            Controls.Add(cbxChooseScreen);
            Name = "UserPage";
            Text = "UserPage";
            Load += UserPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbxChooseScreen;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblChooseScreen;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblRole;
    }
}