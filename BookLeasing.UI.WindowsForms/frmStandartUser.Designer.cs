namespace BookLeasing.UI.WindowsForms
{
    partial class frmStandartUser
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
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgileriDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favorilerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güvenliÇıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddFavs = new System.Windows.Forms.Button();
            this.btnLease = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.rbAuthor = new System.Windows.Forms.RadioButton();
            this.rbPublishing = new System.Windows.Forms.RadioButton();
            this.rbBookName = new System.Windows.Forms.RadioButton();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.favorilerimToolStripMenuItem,
            this.siparişlerimToolStripMenuItem,
            this.güvenliÇıkışToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgileriDeğiştirToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.ayarlarToolStripMenuItem.Text = "Profil Ayarları";
            // 
            // bilgileriDeğiştirToolStripMenuItem
            // 
            this.bilgileriDeğiştirToolStripMenuItem.Name = "bilgileriDeğiştirToolStripMenuItem";
            this.bilgileriDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.bilgileriDeğiştirToolStripMenuItem.Text = "Bilgileri Değiştir";
            this.bilgileriDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.bilgileriDeğiştirToolStripMenuItem_Click);
            // 
            // favorilerimToolStripMenuItem
            // 
            this.favorilerimToolStripMenuItem.Name = "favorilerimToolStripMenuItem";
            this.favorilerimToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.favorilerimToolStripMenuItem.Text = "Favorilerim";
            this.favorilerimToolStripMenuItem.Click += new System.EventHandler(this.favorilerimToolStripMenuItem_Click);
            // 
            // siparişlerimToolStripMenuItem
            // 
            this.siparişlerimToolStripMenuItem.Name = "siparişlerimToolStripMenuItem";
            this.siparişlerimToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.siparişlerimToolStripMenuItem.Text = "Kiraladıklarım";
            this.siparişlerimToolStripMenuItem.Click += new System.EventHandler(this.siparişlerimToolStripMenuItem_Click);
            // 
            // güvenliÇıkışToolStripMenuItem1
            // 
            this.güvenliÇıkışToolStripMenuItem1.Name = "güvenliÇıkışToolStripMenuItem1";
            this.güvenliÇıkışToolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.güvenliÇıkışToolStripMenuItem1.Text = "Güvenli Çıkış";
            this.güvenliÇıkışToolStripMenuItem1.Click += new System.EventHandler(this.güvenliÇıkışToolStripMenuItem1_Click);
            // 
            // btnAddFavs
            // 
            this.btnAddFavs.Location = new System.Drawing.Point(576, 307);
            this.btnAddFavs.Name = "btnAddFavs";
            this.btnAddFavs.Size = new System.Drawing.Size(175, 45);
            this.btnAddFavs.TabIndex = 7;
            this.btnAddFavs.Text = "Favorilerime ekle";
            this.btnAddFavs.UseVisualStyleBackColor = true;
            this.btnAddFavs.Click += new System.EventHandler(this.btnAddFavs_Click);
            // 
            // btnLease
            // 
            this.btnLease.Location = new System.Drawing.Point(576, 367);
            this.btnLease.Name = "btnLease";
            this.btnLease.Size = new System.Drawing.Size(175, 45);
            this.btnLease.TabIndex = 8;
            this.btnLease.Text = "Kirala";
            this.btnLease.UseVisualStyleBackColor = true;
            this.btnLease.Click += new System.EventHandler(this.btnLease_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvBooks.Location = new System.Drawing.Point(0, 24);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(538, 411);
            this.dgvBooks.TabIndex = 9;
            // 
            // rbAuthor
            // 
            this.rbAuthor.AutoSize = true;
            this.rbAuthor.Location = new System.Drawing.Point(27, 85);
            this.rbAuthor.Name = "rbAuthor";
            this.rbAuthor.Size = new System.Drawing.Size(108, 17);
            this.rbAuthor.TabIndex = 10;
            this.rbAuthor.TabStop = true;
            this.rbAuthor.Text = "Yazar Adına Göre";
            this.rbAuthor.UseVisualStyleBackColor = true;
            this.rbAuthor.CheckedChanged += new System.EventHandler(this.rbAuthor_CheckedChanged);
            // 
            // rbPublishing
            // 
            this.rbPublishing.AutoSize = true;
            this.rbPublishing.Location = new System.Drawing.Point(27, 19);
            this.rbPublishing.Name = "rbPublishing";
            this.rbPublishing.Size = new System.Drawing.Size(107, 17);
            this.rbPublishing.TabIndex = 11;
            this.rbPublishing.TabStop = true;
            this.rbPublishing.Text = "Basım Yılına Göre";
            this.rbPublishing.UseVisualStyleBackColor = true;
            this.rbPublishing.CheckedChanged += new System.EventHandler(this.rbPublishing_CheckedChanged);
            // 
            // rbBookName
            // 
            this.rbBookName.AutoSize = true;
            this.rbBookName.Location = new System.Drawing.Point(27, 52);
            this.rbBookName.Name = "rbBookName";
            this.rbBookName.Size = new System.Drawing.Size(105, 17);
            this.rbBookName.TabIndex = 12;
            this.rbBookName.TabStop = true;
            this.rbBookName.Text = "Kitap Adına Göre";
            this.rbBookName.UseVisualStyleBackColor = true;
            this.rbBookName.CheckedChanged += new System.EventHandler(this.rbBookName_CheckedChanged);
            // 
            // txtInfo
            // 
            this.txtInfo.Enabled = false;
            this.txtInfo.Location = new System.Drawing.Point(14, 167);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(175, 20);
            this.txtInfo.TabIndex = 13;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(11, 135);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(10, 13);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = " ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowDetails);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.rbPublishing);
            this.groupBox1.Controls.Add(this.rbAuthor);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.rbBookName);
            this.groupBox1.Location = new System.Drawing.Point(562, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 250);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ara";
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(41, 199);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(119, 23);
            this.btnShowDetails.TabIndex = 14;
            this.btnShowDetails.Text = "Detay Göster";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // frmStandartUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnLease);
            this.Controls.Add(this.btnAddFavs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStandartUser";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStandartUser_FormClosing);
            this.Load += new System.EventHandler(this.frmStandartUser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgileriDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favorilerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişlerimToolStripMenuItem;
        private System.Windows.Forms.Button btnAddFavs;
        private System.Windows.Forms.Button btnLease;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.ToolStripMenuItem güvenliÇıkışToolStripMenuItem1;
        private System.Windows.Forms.RadioButton rbAuthor;
        private System.Windows.Forms.RadioButton rbPublishing;
        private System.Windows.Forms.RadioButton rbBookName;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowDetails;
    }
}

