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
    public class PaymentTypeController
    {
        PaymentTypeManagement _paymentTypeManagement;
        public PaymentTypeController()
        {
            _paymentTypeManagement = new PaymentTypeManagement();
        }

        public bool Add(PaymentType PaymentType)
        {
            CheckFields(PaymentType);
            int result = _paymentTypeManagement.Insert(PaymentType);
            return result > 0;
        }

        public void CheckFields(PaymentType PaymentType)
        {
            if (string.IsNullOrWhiteSpace(PaymentType.Description))
            {
                throw new NotNullException("Ödeme Tipi");
            }
        }

        public bool Update(PaymentType PaymentType)
        {
            CheckFields(PaymentType);
            int result = _paymentTypeManagement.Update(PaymentType);
            return result > 0;
        }

        public bool Delete(PaymentType PaymentType)
        {
            int result = _paymentTypeManagement.Delete(PaymentType.PaymentTypeID);
            return result > 0;

        }

        public PaymentType GetPaymentType(int PaymentTypeID)
        {
            return _paymentTypeManagement.GetPaymentTypeByID(PaymentTypeID);
        }

        public List<PaymentType> GetPaymentTypes()
        {
            return _paymentTypeManagement.GetAllPaymentTypes();
        }

        public int GetTypeIDByName(string name)
        {
            return _paymentTypeManagement.GetTypeIDByName(name);
        }
    }
}
