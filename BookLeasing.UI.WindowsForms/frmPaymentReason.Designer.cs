namespace BookLeasing.UI.WindowsForms
{
    partial class frmPaymentReason
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
            this.dgvPaymentReasons = new System.Windows.Forms.DataGridView();
            this.txtAddPaymentReason = new System.Windows.Forms.TextBox();
            this.btnAddPaymentReason = new System.Windows.Forms.Button();
            this.txtUpdatePayReason = new System.Windows.Forms.TextBox();
            this.btnUpdatePayReason = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentReasons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaymentReasons
            // 
            this.dgvPaymentReasons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentReasons.Location = new System.Drawing.Point(13, 13);
            this.dgvPaymentReasons.Name = "dgvPaymentReasons";
            this.dgvPaymentReasons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentReasons.Size = new System.Drawing.Size(257, 305);
            this.dgvPaymentReasons.TabIndex = 0;
            this.dgvPaymentReasons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentReasons_CellClick);
            // 
            // txtAddPaymentReason
            // 
            this.txtAddPaymentReason.Location = new System.Drawing.Point(420, 79);
            this.txtAddPaymentReason.Name = "txtAddPaymentReason";
            this.txtAddPaymentReason.Size = new System.Drawing.Size(203, 20);
            this.txtAddPaymentReason.TabIndex = 1;
            // 
            // btnAddPaymentReason
            // 
            this.btnAddPaymentReason.Location = new System.Drawing.Point(486, 105);
            this.btnAddPaymentReason.Name = "btnAddPaymentReason";
            this.btnAddPaymentReason.Size = new System.Drawing.Size(137, 38);
            this.btnAddPaymentReason.TabIndex = 2;
            this.btnAddPaymentReason.Text = "Ödeme Sebebi Ekle";
            this.btnAddPaymentReason.UseVisualStyleBackColor = true;
            this.btnAddPaymentReason.Click += new System.EventHandler(this.btnAddPaymentReason_Click);
            // 
            // txtUpdatePayReason
            // 
            this.txtUpdatePayReason.Location = new System.Drawing.Point(420, 162);
            this.txtUpdatePayReason.Name = "txtUpdatePayReason";
            this.txtUpdatePayReason.Size = new System.Drawing.Size(203, 20);
            this.txtUpdatePayReason.TabIndex = 3;
            // 
            // btnUpdatePayReason
            // 
            this.btnUpdatePayReason.Location = new System.Drawing.Point(487, 188);
            this.btnUpdatePayReason.Name = "btnUpdatePayReason";
            this.btnUpdatePayReason.Size = new System.Drawing.Size(137, 38);
            this.btnUpdatePayReason.TabIndex = 4;
            this.btnUpdatePayReason.Text = "Ödeme Sebebi Güncelle";
            this.btnUpdatePayReason.UseVisualStyleBackColor = true;
            this.btnUpdatePayReason.Click += new System.EventHandler(this.btnUpdatePayReason_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ödeme Sebebi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ödeme Sebebi Güncelle";
            // 
            // frmPaymentReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdatePayReason);
            this.Controls.Add(this.txtUpdatePayReason);
            this.Controls.Add(this.btnAddPaymentReason);
            this.Controls.Add(this.txtAddPaymentReason);
            this.Controls.Add(this.dgvPaymentReasons);
            this.Name = "frmPaymentReason";
            this.Text = "frmPaymentReason";
            this.Load += new System.EventHandler(this.frmPaymentReason_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentReasons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaymentReasons;
        private System.Windows.Forms.TextBox txtAddPaymentReason;
        private System.Windows.Forms.Button btnAddPaymentReason;
        private System.Windows.Forms.TextBox txtUpdatePayReason;
        private System.Windows.Forms.Button btnUpdatePayReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}