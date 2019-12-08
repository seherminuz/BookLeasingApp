using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.Model
{
    public class Book
    {
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public string BookName { get; set; }
        public int PageCount { get; set; }
        public int PublishingYear { get; set; }
        public string Summary { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
