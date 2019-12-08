namespace BookLeasing.UI.WindowsForms
{
    partial class frmUpdateBook
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
            this.nudPublishingYear = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishingYear)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPublishingYear
            // 
            this.nudPublishingYear.Location = new System.Drawing.Point(98, 79);
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
            this.nudPublishingYear.Size = new System.Drawing.Size(201, 20);
            this.nudPublishingYear.TabIndex = 53;
            this.nudPublishingYear.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(154, 270);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(145, 28);
            this.btnUpdateBook.TabIndex = 52;
            this.btnUpdateBook.Text = "Kitap Güncelle";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(98, 111);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(201, 20);
            this.txtBookPrice.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Kitap Fiyatı :";
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(99, 149);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(200, 96);
            this.txtSummary.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Özet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Basım Yılı :";
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(98, 45);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(201, 20);
            this.txtPageCount.TabIndex = 40;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(98, 12);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(201, 20);
            this.txtBookName.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Sayfa Sayısı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Kitap Adı :";
            // 
            // frmUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 322);
            this.Controls.Add(this.nudPublishingYear);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.txtBookPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPageCount);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateBook";
            this.Text = "frmUpdateBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdateBook_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdateBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishingYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudPublishingYear;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}