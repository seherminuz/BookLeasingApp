namespace BookLeasing.UI.WindowsForms
{
    partial class frmFavorites
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvFavs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(202, 376);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(144, 41);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Favorilerimden çıkar";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvFavs
            // 
            this.dgvFavs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFavs.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFavs.Location = new System.Drawing.Point(0, 0);
            this.dgvFavs.MultiSelect = false;
            this.dgvFavs.Name = "dgvFavs";
            this.dgvFavs.ReadOnly = true;
            this.dgvFavs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFavs.Size = new System.Drawing.Size(576, 342);
            this.dgvFavs.TabIndex = 3;
            // 
            // frmFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 469);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvFavs);
            this.Name = "frmFavorites";
            this.Text = "frmFavorites";
            this.Load += new System.EventHandler(this.frmFavorites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvFavs;
    }
}