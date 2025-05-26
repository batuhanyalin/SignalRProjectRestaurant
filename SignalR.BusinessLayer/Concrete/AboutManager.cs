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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDAL _AboutDAL;

        public AboutManager(IAboutDAL AboutDAL)
        {
            _AboutDAL = AboutDAL;
        }

        public void TCreate(About entity)
        {
            _AboutDAL.Create(entity);
        }

        public void TDelete(About entity)
        {
            _AboutDAL.Delete(entity);
        }

        public List<About> TGetAll()
        {
            return _AboutDAL.GetListAll();
        }

        public About TGetById(int id)
        {
            return _AboutDAL.GetById(id);
        }

        public void TUpdate(About entity)
        {
            _AboutDAL.Update(entity);
        }
    }
}
