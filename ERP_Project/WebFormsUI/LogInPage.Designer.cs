namespace WebFormsUI
{
    partial class LogInPage
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
            gbxLogIn = new System.Windows.Forms.GroupBox();
            btnForgotMyPassword = new System.Windows.Forms.Button();
            btnEnter = new System.Windows.Forms.Button();
            tbxPassword = new System.Windows.Forms.TextBox();
            tbxUserName = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            lblUserName = new System.Windows.Forms.Label();
            gbxLogIn.SuspendLayout();
            SuspendLayout();
            // 
            // gbxLogIn
            // 
            gbxLogIn.Controls.Add(btnForgotMyPassword);
            gbxLogIn.Controls.Add(btnEnter);
            gbxLogIn.Controls.Add(tbxPassword);
            gbxLogIn.Controls.Add(tbxUserName);
            gbxLogIn.Controls.Add(lblPassword);
            gbxLogIn.Controls.Add(lblUserName);
            gbxLogIn.Location = new System.Drawing.Point(25, 16);
            gbxLogIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxLogIn.Name = "gbxLogIn";
            gbxLogIn.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxLogIn.Size = new System.Drawing.Size(396, 390);
            gbxLogIn.TabIndex = 0;
            gbxLogIn.TabStop = false;
            gbxLogIn.Text = "Log In";
            // 
            // btnForgotMyPassword
            // 
            btnForgotMyPassword.Location = new System.Drawing.Point(39, 248);
            btnForgotMyPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnForgotMyPassword.Name = "btnForgotMyPassword";
            btnForgotMyPassword.Size = new System.Drawing.Size(182, 42);
            btnForgotMyPassword.TabIndex = 5;
            btnForgotMyPassword.Text = "Forgot My Password";
            btnForgotMyPassword.UseVisualStyleBackColor = true;
            btnForgotMyPassword.Click += btnForgotMyPassword_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new System.Drawing.Point(39, 145);
            btnEnter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new System.Drawing.Size(182, 52);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new System.Drawing.Point(121, 91);
            tbxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new System.Drawing.Size(100, 27);
            tbxPassword.TabIndex = 3;
            tbxPassword.KeyDown += tbxPassword_KeyDown;
            // 
            // tbxUserName
            // 
            tbxUserName.Location = new System.Drawing.Point(121, 51);
            tbxUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new System.Drawing.Size(100, 27);
            tbxUserName.TabIndex = 2;
            tbxUserName.KeyDown += tbxUserName_KeyDown;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(36, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(70, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new System.Drawing.Point(33, 60);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(82, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(gbxLogIn);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "LogInPage";
            Text = "Form1";
            Load += LogIn_Load;
            gbxLogIn.ResumeLayout(false);
            gbxLogIn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogIn;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnForgotMyPassword;
        private System.Windows.Forms.Button btnEnter;
    }
}

