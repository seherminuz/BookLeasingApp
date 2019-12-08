using BookLeasing.BLL;
using BookLeasing.CustomException;
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
    public partial class frmAddBook : Form
    {
        Publisher currentPublisher;
        Author currentAuthor;
        Book currentBook;
        BookController _bookController;
        AuthorController _authorController;
        PublisherController _publisherController;
        int authorID;
        int publisherID;
        List<Author> cAuthors;
        List<Publisher> cPublishers;
        string selectedAuthor = "";
        string selectedPublisher = "";
        public frmAddBook()
        {
            InitializeComponent();
            _bookController = new BookController();
            _authorController = new AuthorController();
            _publisherController = new PublisherController();
            currentBook = new Book();
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {
            nudPublishingYear.Maximum = DateTime.Today.Year;
            nudPublishingYear.Minimum = 1950;

            FillList();


            txtAuthorFirstName.Enabled = false;
            txtAuthorSurName.Enabled = false;
            txtPublisherName.Enabled = false;
            btnCreate.Enabled = false;
        }

        private void FillList()
        {

            cAuthors = _authorController.GetAuthors();
            cPublishers = _publisherController.GetPublishers();

            cmbAuthor.ValueMember = "AuthorID";
            cmbAuthor.DisplayMember = "FirstName" + "LastName";
            cmbAuthor.DataSource = cAuthors;

            cmbPublisher.ValueMember = "PublisherID";
            cmbPublisher.DisplayMember = "PublisherName";
            cmbPublisher.DataSource = cPublishers;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            
            CheckComboboxes();
            CheckBoxControls();
            NumericControls();
            currentBook.BookName = txtBookName.Text;
            currentBook.PublishingYear =(int)nudPublishingYear.Value;
            currentBook.Summary = txtSummary.Text;
         

            try
            {
                bool result = _bookController.Add(currentBook);

                if (result)
                {
                    MessageBox.Show("Kitap ekleme başarılı");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NumericControls()
        {
            int pageC = 0;

            decimal pr = 0;

            bool result1 = int.TryParse(txtPageCount.Text, out pageC);
            bool result2 = decimal.TryParse(txtBookPrice.Text, out pr);

            if (result1 && result2)
            {
                currentBook.PageCount = pageC;
                currentBook.Price = pr;
            }
            else
            {
                MessageBox.Show(new NumericFieldException().Message);
                return;
            }
        }

        private void CheckBoxControls()
        {
            if (chkAddAuthor.Checked)
            {
                currentBook.AuthorID = authorID;

            }
            else
            {

                currentBook.AuthorID = cmbAuthor.SelectedIndex + 1;
            }

            if (chkAddPublisher.Checked)
            {
                currentBook.PublisherID = publisherID;

            }
            else
            {
                currentBook.PublisherID = (int)cmbPublisher.SelectedValue;
            }
        }

        private void CheckComboboxes()
        {
            if (cmbPublisher.SelectedIndex < 0 || cmbPublisher.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Yayınevını seçınız");
                return;
            }
            if (cmbAuthor.SelectedIndex < 0 || cmbAuthor.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Yazarı seçınız");
                return;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            currentPublisher = new Publisher();
            currentAuthor = new Author();
            string message = "";
            if (chkAddAuthor.Checked)
            {
                currentAuthor.FirstName = txtAuthorFirstName.Text;
                currentAuthor.LastName = txtAuthorSurName.Text;
                AuthorProcessControl(message);
            }
            else
            {
                selectedAuthor = cmbAuthor.SelectedItem.ToString();
            }

            if (chkAddPublisher.Checked)
            {

                currentPublisher.PublisherName = txtPublisherName.Text;
                PublisherProcessControl(message);

            }
            else
            {
                selectedPublisher = cmbPublisher.SelectedItem.ToString();

            }

            btnAddBook.Enabled = true;
            MessageBox.Show(message + " başarıyla eklendi");
            FillList();
        }

        private void PublisherProcessControl(string message)
        {
            try
            {
                bool result = _publisherController.Add(currentPublisher);
                if (result)
                {
                    message += " Yayınevi";

                }
                publisherID = _publisherController.GetPublisherByName(currentPublisher);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AuthorProcessControl(string message)
        {
            try
            {
                bool result = _authorController.Add(currentAuthor);
                if (result)
                {
                    message = "Yazar";
                }
                authorID = _authorController.GetAuthorbyName(currentAuthor);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chkAddPublisher_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddPublisher.Checked)
            {
                txtPublisherName.Enabled = true;
                cmbPublisher.Enabled = false;
                btnAddBook.Enabled = false;
                btnCreate.Enabled = true;
            }
            else
            {
                txtPublisherName.Enabled = false;
                cmbPublisher.Enabled = true;

            }
        }

        private void chkAddAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddAuthor.Checked)
            {
                txtAuthorFirstName.Enabled = true;
                txtAuthorSurName.Enabled = true;
                cmbAuthor.Enabled = false;
                btnAddBook.Enabled = false;
                btnCreate.Enabled = true;
            }
            else
            {
                txtAuthorFirstName.Enabled = false;
                txtAuthorSurName.Enabled = false;
                cmbAuthor.Enabled = true;

            }
        }
    }
}
