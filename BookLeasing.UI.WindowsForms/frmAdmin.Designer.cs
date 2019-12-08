namespace BookLeasing.UI.WindowsForms
{
    partial class frmAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeTipiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeSebebiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnActivateUsers = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapToolStripMenuItem
            // 
            this.kitapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEkleToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            this.kitapToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.kitapToolStripMenuItem.Text = "Kitap";
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.listeleToolStripMenuItem.Text = "Listele";
            this.listeleToolStripMenuItem.Click += new System.EventHandler(this.listeleToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödemeTipiEkleToolStripMenuItem,
            this.ödemeSebebiEkleToolStripMenuItem,
            this.ödemeEkleToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // ödemeTipiEkleToolStripMenuItem
            // 
            this.ödemeTipiEkleToolStripMenuItem.Name = "ödemeTipiEkleToolStripMenuItem";
            this.ödemeTipiEkleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ödemeTipiEkleToolStripMenuItem.Text = "Ödeme Tipi Ekle";
            this.ödemeTipiEkleToolStripMenuItem.Click += new System.EventHandler(this.ödemeTipiEkleToolStripMenuItem_Click);
            // 
            // ödemeSebebiEkleToolStripMenuItem
            // 
            this.ödemeSebebiEkleToolStripMenuItem.Name = "ödemeSebebiEkleToolStripMenuItem";
            this.ödemeSebebiEkleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ödemeSebebiEkleToolStripMenuItem.Text = "Ödeme Sebebi Ekle";
            this.ödemeSebebiEkleToolStripMenuItem.Click += new System.EventHandler(this.ödemeSebebiEkleToolStripMenuItem_Click);
            // 
            // ödemeEkleToolStripMenuItem
            // 
            this.ödemeEkleToolStripMenuItem.Name = "ödemeEkleToolStripMenuItem";
            this.ödemeEkleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ödemeEkleToolStripMenuItem.Text = "Ödeme Ekle";
            this.ödemeEkleToolStripMenuItem.Click += new System.EventHandler(this.ödemeEkleToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            this.raporlamaToolStripMenuItem.Click += new System.EventHandler(this.raporlamaToolStripMenuItem_Click);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(12, 45);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.Size = new System.Drawing.Size(642, 222);
            this.dgvAdmin.TabIndex = 2;
            // 
            // btnActivateUsers
            // 
            this.btnActivateUsers.Location = new System.Drawing.Point(242, 286);
            this.btnActivateUsers.Name = "btnActivateUsers";
            this.btnActivateUsers.Size = new System.Drawing.Size(198, 38);
            this.btnActivateUsers.TabIndex = 3;
            this.btnActivateUsers.Text = "Üyeleri Onayla";
            this.btnActivateUsers.UseVisualStyleBackColor = true;
            this.btnActivateUsers.Click += new System.EventHandler(this.btn_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 337);
            this.Controls.Add(this.btnActivateUsers);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnActivateUsers;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeTipiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeSebebiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeEkleToolStripMenuItem;
    }
}