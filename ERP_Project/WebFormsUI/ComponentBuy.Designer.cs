namespace WebFormsUI
{
    partial class ComponentBuy
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
            dgvComponentBuy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvComponentBuy).BeginInit();
            SuspendLayout();
            // 
            // dgvComponentBuy
            // 
            dgvComponentBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvComponentBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComponentBuy.Location = new System.Drawing.Point(13, 16);
            dgvComponentBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvComponentBuy.Name = "dgvComponentBuy";
            dgvComponentBuy.RowHeadersWidth = 51;
            dgvComponentBuy.RowTemplate.Height = 24;
            dgvComponentBuy.Size = new System.Drawing.Size(775, 347);
            dgvComponentBuy.TabIndex = 0;
            // 
            // ComponentBuy
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(dgvComponentBuy);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ComponentBuy";
            Text = "ComponentBuy";
            FormClosed += ComponentBuy_FormClosed;
            Load += ComponentBuyLoad;
            ((System.ComponentModel.ISupportInitialize)dgvComponentBuy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComponentBuy;
    }
}