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
    public class MoneyCaseManager : IMoneyCaseService
    {
        private readonly IMoneyCaseDAL _MoneyCaseDAL;

        public MoneyCaseManager(IMoneyCaseDAL MoneyCaseDAL)
        {
            _MoneyCaseDAL = MoneyCaseDAL;
        }

        public void TCreate(MoneyCase entity)
        {
            _MoneyCaseDAL.Create(entity);
        }

        public void TDelete(MoneyCase entity)
        {
            _MoneyCaseDAL.Delete(entity);
        }

        public List<MoneyCase> TGetAll()
        {
            return _MoneyCaseDAL.GetListAll();
        }

        public MoneyCase TGetById(int id)
        {
            return _MoneyCaseDAL.GetById(id);
        }

        public decimal TTotalMoneyCaseAmount()
        {
            return _MoneyCaseDAL.TotalMoneyCaseAmount();
        }

        public void TUpdate(MoneyCase entity)
        {
            _MoneyCaseDAL.Update(entity);
        }
    }
}
