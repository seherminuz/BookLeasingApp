using BookLeasing.BLL;
using BookLeasing.CustomException;
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
    public partial class frmStandartUser : Form
    {
        AutoCompleteStringCollection collection;
        UserController _userController;
        BookController _bookController;
        OrderController _orderController;
        int _orderID = 0;
        int _userID = 0;
        int _bookID = 0;
        User user;
        List<BookDTO> books;
        List<BookDTO> selectedBooks;
        List<BookDTO> leasedBooks;
        BookDTO book;
        FavoriteDTO favBook;
        OrderDetailDTO orderDetail;
        bool isSecureSignOut = false;
        public frmStandartUser(int userID)
        {
            InitializeComponent();
            _userID = userID;
            _userController = new UserController();
            _bookController = new BookController();
            _orderController = new OrderController();
            user = new User();
            collection = new AutoCompleteStringCollection();
            selectedBooks = new List<BookDTO>();
            leasedBooks = new List<BookDTO>();
            books = new List<BookDTO>();
        }

        void AutoComplete(string info)
        {

            foreach (BookDTO item in books)
            {

                if (info == "BookName")
                {

                    collection.Add(item.BookName);
                }
                else if (info == "AuthorName")
                {

                    collection.Add(item.AuthorName);
                }
                else if (info == "PublishingYear")
                {

                    collection.Add(item.PublishingYear.ToString());
                }
            }
            txtInfo.AutoCompleteMode = AutoCompleteMode.Append;
            txtInfo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtInfo.AutoCompleteCustomSource = collection;
        }

        private void frmStandartUser_Load(object sender, EventArgs e)
        {
            user = _userController.GetUser(_userID);
            if (user.IsActive == false)
            {
                btnLease.Enabled = false;
            }

            this.Text = $"Hoşgeldiniz {user.FirstName} {user.LastName}";
            books = _bookController.GetBooks();
            FillListBox(books);
        }

        private void rbPublishing_CheckedChanged(object sender, EventArgs e)
        {
            collection.Clear();
            LabelInfoText("Basım yılı");
            AutoComplete("PublishingYear");
        }

        private void LabelInfoText(string info)
        {
            lblInfo.Text = $"{info}nı giriniz.";
            txtInfo.Enabled = true;
            if (rbPublishing.Checked)
            {
                AutoComplete("PublishingYear");
            }
            else if (rbBookName.Checked)
            {
                AutoComplete("BookName");
            }
            else if (rbAuthor.Checked)
            {
                AutoComplete("AuthorName");
            }
        }

        private void rbBookName_CheckedChanged(object sender, EventArgs e)
        {
            collection.Clear();
            LabelInfoText("Kitap adı");
            AutoComplete("BookName");
        }

        private void rbAuthor_CheckedChanged(object sender, EventArgs e)
        {
            collection.Clear();
            LabelInfoText("Yazar adı");
            AutoComplete("AuthorName");
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInfo.Text))
            {
                MessageBox.Show(new NotNullException("Kitap Arama").Message);
                return;
            }

            string selectedItem = txtInfo.Text;
            int year = 0;
            try
            {
                year = int.Parse(selectedItem);
                selectedBooks = _bookController.GetBookByPreference(selectedItem, false);
            }
            catch (Exception)
            {
                selectedBooks = _bookController.GetBookByPreference(selectedItem, true);
            }
            if (selectedBooks.Count == 0)
            {
                MessageBox.Show(new EmptyListException().Message);
                return;
            }
            FillListBox(selectedBooks);
        }

        private void FillListBox(List<BookDTO> dTOs)
        {
            dgvBooks.DataSource = dTOs;
        }

        private void güvenliÇıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isSecureSignOut = true;
            this.Owner.Show();
            this.Close();

        }

        private void frmStandartUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSecureSignOut)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "NoteBoard", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Owner.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void bilgileriDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateInfo frmUpdateInfo = new frmUpdateInfo(user);
            frmUpdateInfo.ShowDialog();
        }

        private void btnAddFavs_Click(object sender, EventArgs e)
        {
            book = new BookDTO();
            foreach (DataGridViewRow row in dgvBooks.SelectedRows)
            {
                book.BookName = row.Cells[0].Value.ToString();
                book.AuthorName = row.Cells[1].Value.ToString();
                book.PublisherName = row.Cells[2].Value.ToString();
                book.PublishingYear = (int)row.Cells[3].Value;
                book.PageCount = (int)row.Cells[4].Value;
                book.Summary = row.Cells[5].Value.ToString();
                book.Price = (decimal)row.Cells[6].Value;
                book.IsAvailable = (bool)row.Cells[7].Value;
            }
            selectedBooks.Add(book);
            int bookID = _bookController.GetBookIDByName(book.BookName, book.AuthorName);
            favBook = new FavoriteDTO();
            favBook.BookID = bookID;
            favBook.UserID = user.UserID;
            try
            {
                bool result = _bookController.AddFavs(favBook);
                if (result)
                {
                    MessageBox.Show("Kayıt başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void favorilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFavorites frmFavorites = new frmFavorites();
            frmFavorites.ShowDialog();
        }

        private void btnLease_Click(object sender, EventArgs e)
        {
            book = new BookDTO();
            foreach (DataGridViewRow row in dgvBooks.SelectedRows)
            {
                book.BookName = row.Cells[0].Value.ToString();
                book.AuthorName = row.Cells[1].Value.ToString();
                book.PublisherName = row.Cells[2].Value.ToString();
                book.PublishingYear = (int)row.Cells[3].Value;
                book.PageCount = (int)row.Cells[4].Value;
                book.Summary = row.Cells[5].Value.ToString();
                book.Price = (decimal)row.Cells[6].Value;
                book.IsAvailable = (bool)row.Cells[7].Value;
            }
            if (book.IsAvailable)
            {

                leasedBooks.Add(book);
                try
                {
                    bool result = _orderController.Add(user.UserID);
                    _orderID = _orderController.GetOrderOfUser(user.UserID);

                    _bookID = _bookController.GetBookIDByName(book.BookName, book.AuthorName);
                    _bookController.UpdateIsAvailable(_bookID);
                    orderDetail = new OrderDetailDTO();
                    orderDetail.OrderID = _orderID;
                    orderDetail.BookID = _bookID;
                    orderDetail.PaymentID = 1;  ///////////////////       !!!!!!!!!!!!!!!!!!!!!
                    _orderController.AddOrderDetail(orderDetail);
                    if (result)
                    {
                        MessageBox.Show("Keyifli okumalar :)");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bu kitap zaten kirada");
            }
            books = _bookController.GetBooks();
            FillListBox(books);
        }

        private void siparişlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeasedBooks frmLeasedBooks = new frmLeasedBooks(user);
            frmLeasedBooks.ShowDialog();
        }
    }
}
