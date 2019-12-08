namespace BookLeasing.UI.WindowsForms
{
    partial class frmPaymentType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentType));
            this.dgvPaymentType = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayType = new System.Windows.Forms.TextBox();
            this.btnTypeSave = new System.Windows.Forms.Button();
            this.btnPayUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayUpdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaymentType
            // 
            this.dgvPaymentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentType.Location = new System.Drawing.Point(13, 13);
            this.dgvPaymentType.MultiSelect = false;
            this.dgvPaymentType.Name = "dgvPaymentType";
            this.dgvPaymentType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentType.Size = new System.Drawing.Size(245, 331);
            this.dgvPaymentType.TabIndex = 0;
            this.dgvPaymentType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentType_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ödeme Tİpi Ekle  :";
            // 
            // txtPayType
            // 
            this.txtPayType.Location = new System.Drawing.Point(413, 90);
            this.txtPayType.Name = "txtPayType";
            this.txtPayType.Size = new System.Drawing.Size(137, 20);
            this.txtPayType.TabIndex = 3;
            // 
            // btnTypeSave
            // 
            this.btnTypeSave.Location = new System.Drawing.Point(413, 118);
            this.btnTypeSave.Name = "btnTypeSave";
            this.btnTypeSave.Size = new System.Drawing.Size(137, 38);
            this.btnTypeSave.TabIndex = 4;
            this.btnTypeSave.Text = "Ödeme Tipini Kaydet";
            this.btnTypeSave.UseVisualStyleBackColor = true;
            this.btnTypeSave.Click += new System.EventHandler(this.btnTypeSave_Click);
            // 
            // btnPayUpdate
            // 
            this.btnPayUpdate.Location = new System.Drawing.Point(413, 227);
            this.btnPayUpdate.Name = "btnPayUpdate";
            this.btnPayUpdate.Size = new System.Drawing.Size(137, 38);
            this.btnPayUpdate.TabIndex = 5;
            this.btnPayUpdate.Text = "Ödeme Tipini Güncelle";
            this.btnPayUpdate.UseVisualStyleBackColor = true;
            this.btnPayUpdate.Click += new System.EventHandler(this.btnPayUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ödeme Tipini Güncelle : ";
            // 
            // txtPayUpdate
            // 
            this.txtPayUpdate.Location = new System.Drawing.Point(413, 187);
            this.txtPayUpdate.Name = "txtPayUpdate";
            this.txtPayUpdate.Size = new System.Drawing.Size(137, 20);
            this.txtPayUpdate.TabIndex = 7;
            // 
            // frmPaymentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 370);
            this.Controls.Add(this.txtPayUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPayUpdate);
            this.Controls.Add(this.btnTypeSave);
            this.Controls.Add(this.txtPayType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPaymentType);
            this.Name = "frmPaymentType";
            this.Text = "frmPaymentType";
            this.Load += new System.EventHandler(this.frmPaymentType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaymentType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayType;
        private System.Windows.Forms.Button btnTypeSave;
        private System.Windows.Forms.Button btnPayUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPayUpdate;
    }
}