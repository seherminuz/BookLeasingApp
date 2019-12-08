using BookLeasing.DAL;
using BookLeasing.DTO;
using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.BLL
{
    public class PaymentController
    {

        PaymentManagement _paymentManagement;
        public PaymentController()
        {
            _paymentManagement = new PaymentManagement();
        }

        public bool Add(Payment payment)
        {
            int result = _paymentManagement.Insert(payment);
            return result > 0;
        }

        public bool Update(Payment payment)
        {
            int result = _paymentManagement.Update(payment);
            return result > 0;
        }

        public bool Delete(Payment payment)
        {
            int result = _paymentManagement.Delete(payment.PaymentID);
            return result > 0;

        }

        public Payment GetPayment(int paymentID)
        {
            return _paymentManagement.GetPaymentByID(paymentID);
        }
        public List<Payment> GetPayments()
        {
            return _paymentManagement.GetAllPayments();
        }

        public List<ReportDTO> GetAllReports(string startDate, string endDate)
        {
            return _paymentManagement.GetAllReports(startDate, endDate);
        }

        public List<ReportDTO> GetReport1(string startDate, string endDate)
        {
            return _paymentManagement.GetReport1(startDate, endDate);
        }
        public List<ReportDTO> GetReport2(string startDate, string endDate)
        {
            return _paymentManagement.GetReport2(startDate, endDate);
        }
        public List<ReportDTO> GetReport3(string startDate, string endDate)
        {
            return _paymentManagement.GetReport3(startDate, endDate);
        }
        public List<ReportDTO> GetReport4(string startDate, string endDate)
        {
            return _paymentManagement.GetReport4(startDate, endDate);
        }
    }
}
