using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.Model
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime BorrowingDate { get; set; }
        public DateTime GivingBackDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public bool IsDamaged { get; set; }
    }
}
