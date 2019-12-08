using BookLeasing.BLL;
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
    public partial class frmPayment : Form
    {
        PaymentController _paymentController;
        UserController _userController;
        PaymentReasonController _prController;
        PaymentTypeController _ptController;
        public frmPayment()
        {
            InitializeComponent();
            _paymentController = new PaymentController();
            _userController = new UserController();
            _ptController = new PaymentTypeController();
            _prController = new PaymentReasonController();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez.");
                return;
            }
            Payment payment = new Payment();
            try
            {
                payment.Fee = int.Parse(txtFee.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ücret düzgün formatta değil.");
            }
            payment.UserID = _userController.GetUserIDByName(txtUserName.Text);
            payment.ReasonID = _prController.GetReasonIDByName(cmbReason.SelectedItem.ToString());
            payment.PaymentTypeID = _ptController.GetTypeIDByName(cmbType.SelectedItem.ToString());
            try
            {
                bool result = _paymentController.Add(payment);
                if (result)
                {
                    MessageBox.Show("Kayıt başarılı.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void FillComboBoxes()
        {

            foreach (var item in _prController.GetPaymentReasons())
            {
                cmbReason.Items.Add(item);
            }
            cmbReason.DataSource = _prController.GetPaymentReasons();
            cmbType.DataSource = _ptController.GetPaymentTypes();
        }

        private void frmPayment_Load_1(object sender, EventArgs e)
        {
            FillComboBoxes();
        }
    }
}
