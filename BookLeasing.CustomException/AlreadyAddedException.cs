using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.CustomException
{
    public class AlreadyAddedException : Exception
    {
        public override string Message
        {
            get
            {
                return "Bu kitap zaten favorilerinizde mevcut";
            }
        }
    }
}
