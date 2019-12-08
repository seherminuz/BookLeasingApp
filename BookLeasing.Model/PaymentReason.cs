using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.Model
{
   public class PaymentReason
    {
        public int ReasonID { get; set; }
        public string Reason { get; set; }

        public override string ToString()
        {
            return Reason;
        }

    }
}
