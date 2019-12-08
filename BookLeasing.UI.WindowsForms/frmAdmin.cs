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
    public partial class frmAdmin : Form
    {
        UserController _userController;
        List<User> users; 
        public frmAdmin()
        {
            InitializeComponent();
            _userController = new UserController();
            users = new List<User>();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBook frmAdd = new frmAddBook();
            frmAdd.Owner = this;
            frmAdd.ShowDialog();
            
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            FillList();       
        }

        private void btn_Click(object sender, EventArgs e)
        {
            bool result = false;
            string message = string.Empty;
            foreach (User item in users)
            {
               item.IsActive = true;
               result = _userController.PassiveToActive(item);
                if (result == false)
                {
                    message = "Bir hata oluştu.";
                    break;
                }
            }
            if (result)
            {
                message = "Aktifleştirme Başarılı";
                FillList();
               
            }
            MessageBox.Show("Başarılı");
        }

        private void FillList()
        {
            users = _userController.GetPassiveUsers();
            dgvAdmin.DataSource = users;
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBook frmList = new frmListBook();
            frmList.Owner = this;
            frmList.ShowDialog();            
        }

        private void ödemeTipiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentType  frmPaymentType = new frmPaymentType();
            frmPaymentType.Owner = this;
            frmPaymentType.ShowDialog();
           
        }

        private void ödemeSebebiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentReason frm = new frmPaymentReason();
            frm.Owner = this;
            frm.ShowDialog();
        }
              

        private void kitaplarınKiralanmaSayısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.ShowDialog();
        }

        private void ödemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayment frmPayment = new frmPayment();
            frmPayment.ShowDialog();
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.ShowDialog();
        }
    }
}
