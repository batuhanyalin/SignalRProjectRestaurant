using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalRProjectRestaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDAL _DiscountDAL;

        public DiscountManager(IDiscountDAL DiscountDAL)
        {
            _DiscountDAL = DiscountDAL;
        }

        public void TCreate(Discount entity)
        {
            _DiscountDAL.Create(entity);
        }

        public void TDelete(Discount entity)
        {
            _DiscountDAL.Delete(entity);
        }

        public List<Discount> TGetAll()
        {
            return _DiscountDAL.GetListAll();
        }

        public Discount TGetById(int id)
        {
            return _DiscountDAL.GetById(id);
        }

        public void TUpdate(Discount entity)
        {
            _DiscountDAL.Update(entity);
        }
    }
}
