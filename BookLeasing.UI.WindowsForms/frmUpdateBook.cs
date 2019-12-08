using BookLeasing.BLL;
using BookLeasing.DTO;
using BookLeasing.Model;
using PublisherLeasing.BLL;
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
    public partial class frmUpdateBook : Form
    {
        Book currentBook;
        BookController _bookController;
        List<Book> books;

        public frmUpdateBook()
        {
            InitializeComponent();
            _bookController = new BookController();
            currentBook = new Book();
        }

        private void frmUpdateBook_Load(object sender, EventArgs e)
        {
            nudPublishingYear.Maximum = DateTime.Today.Year;
            txtBookName.Text = a;
            nudPublishingYear.Minimum = Convert.ToInt32(b);
            txtPageCount.Text = c;
            txtSummary.Text = d;
            txtBookPrice.Text = f;
        }
        public string a, b, c, d, f, g, h, l;

        private void frmUpdateBook_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            this.Owner.Show();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
           
            currentBook.BookID = Convert.ToInt32(g);
            currentBook.AuthorID = Convert.ToInt32(h);
            currentBook.PublisherID = Convert.ToInt32(l);
            currentBook.BookName = txtBookName.Text;
            currentBook.PageCount = Convert.ToInt32(txtPageCount.Text);
            currentBook.PublishingYear = Convert.ToInt32(nudPublishingYear.Value);
            currentBook.Price = Convert.ToDecimal(txtBookPrice.Text);
            currentBook.Summary = txtSummary.Text;
            _bookController.Update(currentBook);
            try
            {
                bool result = _bookController.Update(currentBook);
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
    }
}
