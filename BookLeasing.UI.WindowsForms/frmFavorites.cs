using BookLeasing.BLL;
using BookLeasing.DTO;
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
    public partial class frmFavorites : Form
    {
        List<BookDTO> books;
        BookController _bookController;
        BookDTO book;
        public frmFavorites()
        {
            InitializeComponent();
            _bookController = new BookController();
            books = new List<BookDTO>();
        }

        private void frmFavorites_Load(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void FillListBox()
        {
            books = _bookController.GetFavs();
            dgvFavs.DataSource = books;
            if (books.Count <= 0)
            {
                MessageBox.Show("Favorilerde ekli ürün bulunmamaktadır.");
            }
        }

        private BookDTO GetBookFromDGV()
        {
            book = new BookDTO();
            foreach (DataGridViewRow row in dgvFavs.SelectedRows)
            {
                book.BookName = row.Cells[0].Value.ToString();
                book.AuthorName = row.Cells[1].Value.ToString();
                book.PublisherName = row.Cells[2].Value.ToString();
                book.PublishingYear = (int)row.Cells[3].Value;
            }
            return book;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            book = GetBookFromDGV();
            int bookID = _bookController.GetBookIDByName(book.BookName, book.AuthorName);
            _bookController.DeleteFavs(bookID);
            FillListBox();
        }
    }
}
