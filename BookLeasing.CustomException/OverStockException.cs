using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.CustomException
{
    public class OverStockException : Exception
    {
        public override string Message
        {
            get
            {
                return "En fazla 3 kitap kiralayabilirsiniz. Yeni kitap kiralayabilmek için, kiraladıklarınızdan en az bir kitabı iade etmelisiniz";
            }
        }
    }
}
