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
    public partial class frmAddPublisher : Form
    {
        Publisher currentPublisher;
        PublisherController _publisherController;
        public frmAddPublisher()
        {
            InitializeComponent();
            _publisherController = new PublisherController();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            currentPublisher = new Publisher();
            currentPublisher.PublisherName = txtPublisherName.Text;
            _publisherController.Add(currentPublisher);

        }
    }
}
