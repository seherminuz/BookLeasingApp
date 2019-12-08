using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.DTO
{
    public class ReportDTO
    {
        public DateTime BorrowingDate { get; set; }
        public string BookName { get; set; }
        public string UserName { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public decimal Total { get; set; }
    }
}
