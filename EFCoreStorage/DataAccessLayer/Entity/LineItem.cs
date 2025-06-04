using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class LineItem
    {
        public int LineItemId { get; set; }

        [Range(1, 5, ErrorMessage =                      //#B
           "This order is over the limit of 5 books.")] //#B
        public byte LineNum { get; set; }

        public short NumBooks { get; set; }
        public decimal BookPrice { get; set; }

        //relationships
        public int OrderId { get; set; }
        public int BookId { get; set; }

        public Book ChosenBook { get; set; }

    }

}
