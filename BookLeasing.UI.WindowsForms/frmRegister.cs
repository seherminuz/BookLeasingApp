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
    public partial class frmRegister : Form
    {
        UserController _userController;
        public frmRegister()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor");
                txtConfirmPassword.BackColor = Color.Red;
                txtConfirmPassword.SelectAll();
                return;
            }

            User newUser = new User();
            newUser.FirstName = txtName.Text;
            newUser.LastName = txtSurname.Text;
            newUser.EMail = txtMail.Text;
            newUser.CreatedDate = DateTime.Today;
            newUser.IsActive = false;
            newUser.Password = txtPassword.Text;


            try
            {
                bool result = _userController.Add(newUser);
                if (result)
                {
                    MessageBox.Show("Kayıt başarılı");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfirm.Checked)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void linklblContract_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmContract frmContract = new frmContract();
            frmContract.ShowDialog();
        }
    }
}
