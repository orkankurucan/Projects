namespace WebFormsUI
{
    partial class CustomerOrder
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
            dgvCustomerOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomerOrder
            // 
            dgvCustomerOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerOrder.Location = new System.Drawing.Point(13, 16);
            dgvCustomerOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvCustomerOrder.Name = "dgvCustomerOrder";
            dgvCustomerOrder.RowHeadersWidth = 51;
            dgvCustomerOrder.RowTemplate.Height = 24;
            dgvCustomerOrder.Size = new System.Drawing.Size(780, 485);
            dgvCustomerOrder.TabIndex = 0;
            // 
            // CustomerOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(dgvCustomerOrder);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "CustomerOrder";
            Text = "CustomerOrder";
            FormClosed += CustomerOrder_FormClosed;
            Load += CustomerOrderLoad;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerOrder;
    }
}