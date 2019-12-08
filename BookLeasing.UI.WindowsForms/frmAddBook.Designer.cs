namespace BookLeasing.UI.WindowsForms
{
    partial class frmAddBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudPublishingYear = new System.Windows.Forms.NumericUpDown();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtAuthorSurName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAuthorFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPublisher = new System.Windows.Forms.ComboBox();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAddPublisher = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAddAuthor = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishingYear)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudPublishingYear);
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.txtBookPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSummary);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPageCount);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(471, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 345);
            this.panel1.TabIndex = 27;
            // 
            // nudPublishingYear
            // 
            this.nudPublishingYear.Location = new System.Drawing.Point(128, 148);
            this.nudPublishingYear.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPublishingYear.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPublishingYear.Name = "nudPublishingYear";
            this.nudPublishingYear.Size = new System.Drawing.Size(214, 20);
            this.nudPublishingYear.TabIndex = 2;
            this.nudPublishingYear.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(266, 279);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 57);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Kitap Ekle";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(128, 201);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(213, 20);
            this.txtBookPrice.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kitap Fiyatı :";
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(128, 240);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(213, 20);
            this.txtSummary.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Özet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Basım Yılı :";
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(128, 110);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(213, 20);
            this.txtPageCount.TabIndex = 1;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(128, 70);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(213, 20);
            this.txtBookName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kitap Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sayfa Sayısı :";
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(6, 66);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(213, 20);
            this.txtPublisherName.TabIndex = 26;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(263, 295);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 61);
            this.btnCreate.TabIndex = 26;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtAuthorSurName
            // 
            this.txtAuthorSurName.Location = new System.Drawing.Point(98, 97);
            this.txtAuthorSurName.Name = "txtAuthorSurName";
            this.txtAuthorSurName.Size = new System.Drawing.Size(213, 20);
            this.txtAuthorSurName.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Yazar Soyadı :";
            // 
            // txtAuthorFirstName
            // 
            this.txtAuthorFirstName.Location = new System.Drawing.Point(98, 50);
            this.txtAuthorFirstName.Name = "txtAuthorFirstName";
            this.txtAuthorFirstName.Size = new System.Drawing.Size(213, 20);
            this.txtAuthorFirstName.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Yazar Adı :";
            // 
            // cmbPublisher
            // 
            this.cmbPublisher.FormattingEnabled = true;
            this.cmbPublisher.Location = new System.Drawing.Point(9, 29);
            this.cmbPublisher.Name = "cmbPublisher";
            this.cmbPublisher.Size = new System.Drawing.Size(121, 21);
            this.cmbPublisher.TabIndex = 29;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(98, 19);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(121, 21);
            this.cmbAuthor.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAddPublisher);
            this.groupBox1.Controls.Add(this.cmbPublisher);
            this.groupBox1.Controls.Add(this.txtPublisherName);
            this.groupBox1.Location = new System.Drawing.Point(27, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 126);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yayınevi";
            // 
            // chkAddPublisher
            // 
            this.chkAddPublisher.AutoSize = true;
            this.chkAddPublisher.Location = new System.Drawing.Point(179, 29);
            this.chkAddPublisher.Name = "chkAddPublisher";
            this.chkAddPublisher.Size = new System.Drawing.Size(152, 17);
            this.chkAddPublisher.TabIndex = 30;
            this.chkAddPublisher.Text = "Kendim Eklemek İstiyorum.";
            this.chkAddPublisher.UseVisualStyleBackColor = true;
            this.chkAddPublisher.CheckedChanged += new System.EventHandler(this.chkAddPublisher_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAddAuthor);
            this.groupBox2.Controls.Add(this.cmbAuthor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAuthorFirstName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtAuthorSurName);
            this.groupBox2.Location = new System.Drawing.Point(27, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 137);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yazar";
            // 
            // chkAddAuthor
            // 
            this.chkAddAuthor.AutoSize = true;
            this.chkAddAuthor.Location = new System.Drawing.Point(236, 20);
            this.chkAddAuthor.Name = "chkAddAuthor";
            this.chkAddAuthor.Size = new System.Drawing.Size(152, 17);
            this.chkAddAuthor.TabIndex = 31;
            this.chkAddAuthor.Text = "Kendim Eklemek İstiyorum.";
            this.chkAddAuthor.UseVisualStyleBackColor = true;
            this.chkAddAuthor.CheckedChanged += new System.EventHandler(this.chkAddAuthor_CheckedChanged);
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreate);
            this.Name = "frmAddBook";
            this.Text = "frmAddBook";
            this.Load += new System.EventHandler(this.frmAddBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishingYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudPublishingYear;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtAuthorSurName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAuthorFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPublisher;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAddPublisher;
        private System.Windows.Forms.CheckBox chkAddAuthor;
    }
}