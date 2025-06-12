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
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDAL _OrderDetailDAL;

        public OrderDetailManager(IOrderDetailDAL OrderDetailDAL)
        {
            _OrderDetailDAL = OrderDetailDAL;
        }

        public void TCreate(OrderDetail entity)
        {
            _OrderDetailDAL.Create(entity);
        }

        public void TDelete(OrderDetail entity)
        {
            _OrderDetailDAL.Delete(entity);
        }

        public List<OrderDetail> TGetAll()
        {
            return _OrderDetailDAL.GetListAll();
        }

        public OrderDetail TGetById(int id)
        {
            return _OrderDetailDAL.GetById(id);
        }

        public void TUpdate(OrderDetail entity)
        {
            _OrderDetailDAL.Update(entity);
        }
    }
}
