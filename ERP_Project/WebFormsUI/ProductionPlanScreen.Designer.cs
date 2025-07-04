namespace WebFormsUI
{
    partial class ProductionPlanScreen
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
            dgvProductionPlan = new System.Windows.Forms.DataGridView();
            btnGoToUserPage = new System.Windows.Forms.Button();
            btnShowPlans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductionPlan).BeginInit();
            SuspendLayout();
            // 
            // dgvProductionPlan
            // 
            dgvProductionPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductionPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductionPlan.Location = new System.Drawing.Point(13, 11);
            dgvProductionPlan.Name = "dgvProductionPlan";
            dgvProductionPlan.RowHeadersWidth = 51;
            dgvProductionPlan.Size = new System.Drawing.Size(775, 317);
            dgvProductionPlan.TabIndex = 0;
            dgvProductionPlan.CellClick += dgvProductionPlan_CellClick;
            // 
            // btnGoToUserPage
            // 
            btnGoToUserPage.Location = new System.Drawing.Point(107, 375);
            btnGoToUserPage.Name = "btnGoToUserPage";
            btnGoToUserPage.Size = new System.Drawing.Size(137, 29);
            btnGoToUserPage.TabIndex = 1;
            btnGoToUserPage.Text = "Go To User Page";
            btnGoToUserPage.UseVisualStyleBackColor = true;
            btnGoToUserPage.Click += btnGoToUserPage_Click;
            // 
            // btnShowPlans
            // 
            btnShowPlans.Location = new System.Drawing.Point(296, 375);
            btnShowPlans.Name = "btnShowPlans";
            btnShowPlans.Size = new System.Drawing.Size(137, 29);
            btnShowPlans.TabIndex = 2;
            btnShowPlans.Text = "Show Plans";
            btnShowPlans.UseVisualStyleBackColor = true;
            btnShowPlans.Click += btnShowPlans_Click;
            // 
            // ProductionPlanScreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnShowPlans);
            Controls.Add(btnGoToUserPage);
            Controls.Add(dgvProductionPlan);
            Name = "ProductionPlanScreen";
            Text = "ProductionPlanScreen";
            Load += ProductionPlanScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductionPlan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductionPlan;
        private System.Windows.Forms.Button btnGoToUserPage;
        private System.Windows.Forms.Button btnShowPlans;
    }
}