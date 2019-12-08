using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.DTO
{
    public class BookDTO
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public int PublishingYear { get; set; }
        public int PageCount { get; set; }
        public string Summary { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
    }
}
