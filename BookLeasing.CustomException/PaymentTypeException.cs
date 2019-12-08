using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.CustomException
{
    public class PaymentTypeException : Exception
    {
        public override string Message
        {
            get
            {
                return "Bu Ödeme Tipi Mevcut.";
            }
        }
    }
}
