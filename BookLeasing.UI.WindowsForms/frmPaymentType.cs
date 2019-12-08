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
    public partial class frmPaymentType : Form
    {
        PaymentTypeController _paymentTypeController;
        List<PaymentType> PayType;
        PaymentType currentPay;

        public frmPaymentType()
        {
            InitializeComponent();
            _paymentTypeController = new PaymentTypeController();
            PayType = new List<PaymentType>();
        }

        private void frmPaymentType_Load(object sender, EventArgs e)
        {
            FillList();
        
        }

        private void btnTypeSave_Click(object sender, EventArgs e)
        {

            currentPay = new PaymentType();
            currentPay.Description = txtPayType.Text;
            PayType = _paymentTypeController.GetPaymentTypes();

            foreach (PaymentType item in PayType)
            {
                if (txtPayType.Text == item.Description)
                {
                    throw new PaymentTypeException();
                }
            }
            try
            {
                bool result = _paymentTypeController.Add(currentPay);

                if (result)
                {
                    MessageBox.Show("Ödeme tip ekleme başarılı");
                    FillList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FillList()
        {
            PayType = _paymentTypeController.GetPaymentTypes();
            dgvPaymentType.DataSource = PayType;
        }


        private void dgvPaymentType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPayUpdate.Text = dgvPaymentType.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void btnPayUpdate_Click(object sender, EventArgs e)
        {
            currentPay = new PaymentType();
            currentPay.PaymentTypeID = (int)dgvPaymentType.SelectedRows[0].Cells[0].Value;

            currentPay.Description = txtPayUpdate.Text;
            _paymentTypeController.Update(currentPay);
            FillList();
        }
    }
}
