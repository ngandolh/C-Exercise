using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class BookAuthor
    {
        public int BookId { get; set; } //#H
        public int AuthorId { get; set; } //#H
        public byte Order { get; set; } //#I

        //-----------------------------
        //Relationships

        public Book Book { get; set; } //#J
        public Author Author { get; set; } //#K
    }
}
