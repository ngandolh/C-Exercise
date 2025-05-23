using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Review
    {
        public int ReviewId { get; set; }   
        public string VoteName { get; set; }
        public int NumStars { get; set; }
        public string Comment { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
