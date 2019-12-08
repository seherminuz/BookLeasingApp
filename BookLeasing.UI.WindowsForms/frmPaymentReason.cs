using BookLeasing.BLL;
using BookLeasing.CustomException;
using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLeasing.UI.WindowsForms
{
    public partial class frmPaymentReason : Form
    {
        PaymentReasonController _paymentReasonController;
        List<PaymentReason> PaymentReasonType;
        PaymentReason currentPay;

        public frmPaymentReason()
        {
            InitializeComponent();
            _paymentReasonController = new PaymentReasonController();
            PaymentReasonType = new List<PaymentReason>();
        }

        private void frmPaymentReason_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void FillList()
        {
            PaymentReasonType = _paymentReasonController.GetPaymentReasons();
            dgvPaymentReasons.DataSource = PaymentReasonType;
        }

        private void btnAddPaymentReason_Click(object sender, EventArgs e)
        {
            currentPay = new PaymentReason();
            currentPay.Reason = txtAddPaymentReason.Text;
            PaymentReasonType = _paymentReasonController.GetPaymentReasons();

            foreach (PaymentReason item in PaymentReasonType)
            {
                if (txtAddPaymentReason.Text == item.Reason)
                {
                    throw new PaymentReasonException();
                }
            }
            try
            {
                bool result = _paymentReasonController.Add(currentPay);

                if (result)
                {
                    MessageBox.Show("Ödeme nedeni ekleme başarılı");
                    FillList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdatePayReason_Click(object sender, EventArgs e)
        {
            currentPay = new PaymentReason();
            currentPay.ReasonID= (int)dgvPaymentReasons.SelectedRows[0].Cells[0].Value;

            currentPay.Reason = txtUpdatePayReason.Text;
            _paymentReasonController.Update(currentPay);
            FillList();
        }

        private void dgvPaymentReasons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdatePayReason.Text = dgvPaymentReasons.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
