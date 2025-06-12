using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities.Concrete;
using SignalRProjectRestaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDAL _OrderDAL;

        public OrderManager(IOrderDAL OrderDAL)
        {
            _OrderDAL = OrderDAL;
        }

        public int TActiveOrderCount()
        {
            return _OrderDAL.ActiveOrderCount();
        }

        public void TCreate(Order entity)
        {
            _OrderDAL.Create(entity);
        }

        public void TDelete(Order entity)
        {
            _OrderDAL.Delete(entity);
        }

        public List<Order> TGetAll()
        {
            return _OrderDAL.GetListAll();
        }

        public Order TGetById(int id)
        {
            return _OrderDAL.GetById(id);
        }

        public decimal TLastOrderPrice()
        {
            return _OrderDAL.LastOrderPrice();
        }

        public int TPassiveOrderCount()
        {
            return _OrderDAL.PassiveOrderCount();
        }

        public decimal TTodayTotalPrice()
        {
            return _OrderDAL.TodayTotalPrice();
        }

        public int TTotalOrderCount()
        {
            return _OrderDAL.TotalOrderCount();
        }

        public void TUpdate(Order entity)
        {
            _OrderDAL.Update(entity);
        }
    }
}
