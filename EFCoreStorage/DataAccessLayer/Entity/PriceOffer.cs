﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PriceOffer
    {
        public int PriceOfferId { get; set; }
        public decimal NewPrice { get; set; }
        public string PromotionalText { get; set; }

        //-----------------------------------------------
        //Relationships

        public int BookId { get; set; } //#b
    }
}
