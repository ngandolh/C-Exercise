using BizLogic.GenericInterfaces;
using DataAccessLayer.Entity;

namespace BizLogic.Orders
{
    public interface IPlaceOrderAction : IBizAction<PlaceOrderInDto, Order> 
    {
    }
}
