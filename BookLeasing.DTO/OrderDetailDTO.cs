using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.DTO
{
    public class OrderDetailDTO
    {
        public int OrderID { get; set; }
        public int BookID { get; set; }
        public int PaymentID { get; set; }
    }
}
