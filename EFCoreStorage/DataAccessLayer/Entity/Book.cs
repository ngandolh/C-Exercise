using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }   
        public string ImageUrl { get; set; }
        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
