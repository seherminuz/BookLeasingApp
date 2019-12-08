using BookLeasing.CustomException;
using BookLeasing.DAL;
using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.BLL
{
    public class PaymentReasonController
    {

        PaymentReasonManagement _paymentReasonManagement;
        public PaymentReasonController()
        {
            _paymentReasonManagement = new PaymentReasonManagement();
        }

        public bool Add(PaymentReason PaymentReason)
        {
            CheckFields(PaymentReason);
            int result = _paymentReasonManagement.Insert(PaymentReason);
            return result > 0;
        }

        void CheckFields(PaymentReason PaymentReason)
        {
            if (string.IsNullOrWhiteSpace(PaymentReason.Reason))
            {
                throw new NotNullException("Ödeme Sebebi");
            }
        }

        public bool Update(PaymentReason PaymentReason)
        {
            CheckFields(PaymentReason);
            int result = _paymentReasonManagement.Update(PaymentReason);
            return result > 0;

        }

        public int GetReasonIDByName(string name)
        {
            return _paymentReasonManagement.GetReasonIDByName(name);
        }

        public bool Delete(PaymentReason PaymentReason)
        {
            int result = _paymentReasonManagement.Delete(PaymentReason.ReasonID);
            return result > 0;

        }

        public PaymentReason GetPaymentReason(int PaymentReasonID)
        {
            return _paymentReasonManagement.GetPaymentReasonByID(PaymentReasonID);
        }

        public List<PaymentReason> GetPaymentReasons()
        {
            return _paymentReasonManagement.GetAllPaymentReasons();
        }
    }
}
