using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.CustomException
{
    public class MailFormatException : Exception
    {
        public override string Message
        {
            get
            {
                return "Mail adresi doğru formatta değil.";
            }
        }
    }

}
