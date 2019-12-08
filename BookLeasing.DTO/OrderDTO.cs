using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.DTO
{
   
     public class OrderDTO
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public DateTime BorrowingDate { get; set; }
        public DateTime GivingBackDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public bool IsDamaged { get; set; }
    }
}
