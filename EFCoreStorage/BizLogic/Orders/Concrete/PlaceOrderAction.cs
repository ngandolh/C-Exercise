//using BizDbAccess;
//using BizLogic.GenericInterfaces;
//using DataAccessLayer;
//using DataAccessLayer.Entity;

//namespace BizLogic.Orders.Concrete
//{
//    public class PlaceOrderAction :
//        BizActionErrors,  //#A
//        IBizAction<PlaceOrderInDto, Order> //#B
//    {
//        private readonly IPlaceOrderDbAccess _dbAccess;

//        public PlaceOrderAction(IPlaceOrderDbAccess dbAccess)//#C
//        {
//            _dbAccess = dbAccess;
//        }

//        /// <summary>
//        /// This validates the input and if OK creates 
//        /// an order and calls the _dbAccess to add to orders
//        /// </summary>
//        /// <param name="dto"></param>
//        /// <returns>returns an Order. Will be null if there are errors</returns>
//        public Order Action(PlaceOrderInDto dto) //#D
//        {
//            if (!dto.AcceptTAndCs)                    //#E
//            {                                         //#E
//                AddError(                             //#E
//    "You must accept the T&Cs to place an order.");   //#E
//                return null;                          //#E
//            }                                         //#E
//            if (!dto.LineItems.Any())                 //#E
//            {                                         //#E
//                AddError("No items in your basket."); //#E
//                return null;                          //#E
//            }                                         //#E

//            var booksDict =                                //#F
//                _dbAccess.FindBooksByIdsWithPriceOffers    //#F
//                     (dto.LineItems.Select(x => x.BookId));//#F
//            var order = new Order                          //#G
//            {                                              //#G
//                CustomerId = dto.UserId,                   //#G
//                LineItems =                                //#G
//                    FormLineItemsWithErrorChecking         //#G
//                         (dto.LineItems, booksDict)        //#G
//            };                                             //#G

//            if (!HasErrors)           //#H
//                _dbAccess.Add(order); //#H

//            return HasErrors ? null : order; //#I
//        }

//        private List<LineItem> FormLineItemsWithErrorChecking//#J
//            (IEnumerable<OrderLineItem> lineItems,            //#J
//             IDictionary<int, Book> booksDict)                 //#J
//        {
//            var result = new List<LineItem>();
//            var i = 1;

//            foreach (var lineItem in lineItems)  //#K
//            {
//                if (!booksDict.                             //#L
//                    ContainsKey(lineItem.BookId))           //#L
//                    throw new InvalidOperationException //#L
//("An order failed because book, " +                     //#L
// $"id = {lineItem.BookId} was missing.");               //#L

//                var book = booksDict[lineItem.BookId];
//                var bookPrice =
//                    book.Promotion?.NewPrice ?? book.Price; //#M
//                if (bookPrice <= 0)                         //#N
//                    AddError(                               //#N
//    $"Sorry, the book '{book.Title}' is not for sale.");    //#N
//                else
//                {
//                    //Valid, so add to the order
//                    result.Add(new LineItem         //#O
//                    {                               //#O
//                        BookPrice = bookPrice,      //#O
//                        ChosenBook = book,          //#O
//                        LineNum = (byte)(i++),      //#O
//                        NumBooks = lineItem.NumBooks//#O
//                    });
//                }
//            }
//            return result; //#P
//        }
//    }
//}
