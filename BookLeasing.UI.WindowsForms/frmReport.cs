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
    public partial class frmReport : Form
    {
        PaymentController _paymentController;
        List<ReportDTO> reportDTOs;
        public frmReport()
        {
            InitializeComponent();
            _paymentController = new PaymentController();
            reportDTOs = new List<ReportDTO>();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            reportDTOs = _paymentController.GetAllReports(txtStartDate.Text, txtEndDate.Text);
            dgvReport.DataSource = reportDTOs;
        }

        private void btnUye_Click(object sender, EventArgs e)
        {
            reportDTOs = _paymentController.GetReport3(txtStartDate.Text, txtEndDate.Text);
            dgvReport.DataSource = reportDTOs;
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            reportDTOs = _paymentController.GetReport1(txtStartDate.Text, txtEndDate.Text);
            dgvReport.DataSource = reportDTOs;
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            reportDTOs = _paymentController.GetReport2(txtStartDate.Text, txtEndDate.Text);
            dgvReport.DataSource = reportDTOs;
        }

        private void btnCiro_Click(object sender, EventArgs e)
        {
            reportDTOs = _paymentController.GetReport4(txtStartDate.Text, txtEndDate.Text);
            dgvReport.DataSource = reportDTOs;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }
    }
}
