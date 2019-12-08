namespace BookLeasing.UI.WindowsForms
{
    partial class frmLeasedBooks
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
            this.dgvLeased = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeased)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLeased
            // 
            this.dgvLeased.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeased.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeased.Location = new System.Drawing.Point(0, 0);
            this.dgvLeased.MultiSelect = false;
            this.dgvLeased.Name = "dgvLeased";
            this.dgvLeased.ReadOnly = true;
            this.dgvLeased.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeased.Size = new System.Drawing.Size(800, 450);
            this.dgvLeased.TabIndex = 1;
            // 
            // frmLeasedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLeased);
            this.Name = "frmLeasedBooks";
            this.Text = "frmLeasedBooks";
            this.Load += new System.EventHandler(this.frmLeasedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeased)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeased;
    }
}