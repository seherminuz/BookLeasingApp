using BookLeasing.BLL;
using BookLeasing.DTO;
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
    public partial class frmLeasedBooks : Form
    {
        User currentUser;
        List<OrderDTO> books;
        OrderController _orderController;
        public frmLeasedBooks(User user)
        {
            InitializeComponent();
            books = new List<OrderDTO>();
            currentUser = user;
            _orderController = new OrderController();
        }

        private void frmLeasedBooks_Load(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void FillListBox()
        {
            books = _orderController.GetOrderDTOsOfUser(currentUser.UserID);
            if (books.Count <= 0)
            {
                MessageBox.Show("Kiralanan kitap geçmişiniz boş.");
            }
            dgvLeased.DataSource = books;
        }
    }
}
