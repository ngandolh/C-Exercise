using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime DateOrderedUtc { get; set; }
        public Guid CustomerId { get; set; }

        // relationships

        public ICollection<LineItem> LineItems { get; set; }

        // Extra columns not used by EF

        public string OrderNumber => $"SO{OrderId:D6}";

        public Order()
        {
            DateOrderedUtc = DateTime.UtcNow;
        }
    }
}
