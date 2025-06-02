using DataAccessLayer;
using DataAccessLayer.Entity;

namespace BizDbAccess
{
    public interface IPlaceOrderDbAccess
    {
        /// <summary>
        /// This finds any books that fits the BookIds given to it
        /// </summary>
        /// <param name="bookIds"></param>
        /// <returns>A dictionary with the BookId as the key, and the Book as the value</returns>
        IDictionary<int, Book> FindBooksByIdsWithPriceOffers(IEnumerable<int> bookIds);

        void Add(Order newOrder);
    }

    public class PlaceOrderDbAccess : IPlaceOrderDbAccess
    {
        private readonly AppDbContext _context;

        public PlaceOrderDbAccess(AppDbContext context)//#A
        {
            _context = context;
        }

        #region Add
        /// <summary>
        /// This finds any books that fits the BookIds given to it, with any optional promotion
        /// </summary>
        /// <param name="bookIds"></param>
        /// <returns>A dictionary with the BookId as the key, and the Book as the value</returns>
        /// 
        #endregion
        public void Add(Order newOrder)
        {
            _context.Orders.Add(newOrder);
        }

        #region FindBooksByIdsWithPriceOffers
        #endregion
        public IDictionary<int, Book> FindBooksByIdsWithPriceOffers(IEnumerable<int> bookIds)
        {
            throw new NotImplementedException();
        }
    }
}
