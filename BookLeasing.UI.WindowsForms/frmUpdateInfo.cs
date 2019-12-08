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
    public partial class frmUpdateInfo : Form
    {
        User currentUser;
        UserController _userController;

        public frmUpdateInfo(User user)
        {
            InitializeComponent();
            currentUser = user;
            _userController = new UserController();

        }

        private void frmUpdateInfo_Load(object sender, EventArgs e)
        {
            txtMail.Text = currentUser.EMail;
            txtName.Text = currentUser.FirstName;
            txtSurname.Text = currentUser.LastName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentUser.Password == txtPassword.Text)
            {
                currentUser.FirstName = txtName.Text;
                currentUser.LastName = txtSurname.Text;

                if (!string.IsNullOrWhiteSpace(txtNewPassword.Text))
                {
                    if (txtNewPassword.Text == txtNewPasswordConfirm.Text)
                    {
                        currentUser.Password = txtNewPassword.Text;
                        Properties.Settings.Default.IsPasswordUpdate = true;
                    }
                    else
                    {
                        MessageBox.Show("Şifreler uyuşmuyor");
                        return;
                    }
                }

                try
                {
                    bool result = _userController.Update(currentUser);
                    if (result)
                    {
                        MessageBox.Show("Güncelleme başarılı");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme esnasında hata oluştu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Şifre yanlış");
            }
        }

        private void chbShowPasswords_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPasswords.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtNewPassword.UseSystemPasswordChar = false;
                txtNewPasswordConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtNewPassword.UseSystemPasswordChar = true;
                txtNewPasswordConfirm.UseSystemPasswordChar = true;
            }
        }
    }
}
