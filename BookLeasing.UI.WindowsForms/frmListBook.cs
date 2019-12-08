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
    public partial class frmListBook : Form
    {
        BookController _bookController;
        List<BookDTO> books;
        

        public frmListBook()
        {
            InitializeComponent();
            _bookController = new BookController();
            books = new List<BookDTO>();
           
        }


        private void frmListBook_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void dgvListBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUpdateBook frmUpdate = new frmUpdateBook();
            frmUpdate.Owner = this;
            frmUpdate.a = dgvListBook.SelectedRows[0].Cells[0].Value.ToString();
            frmUpdate.b = dgvListBook.SelectedRows[0].Cells[3].Value.ToString();
            frmUpdate.c = dgvListBook.SelectedRows[0].Cells[4].Value.ToString();
            frmUpdate.d = dgvListBook.SelectedRows[0].Cells[5].Value.ToString();
            frmUpdate.f = dgvListBook.SelectedRows[0].Cells[6].Value.ToString();
            frmUpdate.g = dgvListBook.SelectedRows[0].Cells[8].Value.ToString();
            frmUpdate.h = dgvListBook.SelectedRows[0].Cells[9].Value.ToString();
            frmUpdate.l = dgvListBook.SelectedRows[0].Cells[10].Value.ToString();
            frmUpdate.ShowDialog();
            this.Hide();
        }

        public void FillList()
        {
            books = _bookController.GetBooks();
            dgvListBook.DataSource = books;
        }
    }
}
