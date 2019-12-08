namespace BookLeasing.UI.WindowsForms
{
    partial class frmListBook
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
            this.dgvListBook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListBook
            // 
            this.dgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBook.Location = new System.Drawing.Point(12, 12);
            this.dgvListBook.Name = "dgvListBook";
            this.dgvListBook.Size = new System.Drawing.Size(692, 290);
            this.dgvListBook.TabIndex = 0;
            this.dgvListBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListBook_CellClick);
            // 
            // frmListBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 416);
            this.Controls.Add(this.dgvListBook);
            this.Name = "frmListBook";
            this.Text = "frmListBook";
            this.Load += new System.EventHandler(this.frmListBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListBook;
    }
}