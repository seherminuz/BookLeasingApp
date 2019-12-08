using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.Model
{
   public class Payment
    {
        public int PaymentID { get; set; }
        public int UserID { get; set; }
        public int ReasonID { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentTypeID { get; set; }
        public int Fee { get; set; }
    }
}
