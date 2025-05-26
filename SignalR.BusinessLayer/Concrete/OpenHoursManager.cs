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
    public class OpenHoursManager : IOpenHoursService
    {
        private readonly IOpenHoursDAL _OpenHoursDAL;

        public OpenHoursManager(IOpenHoursDAL OpenHoursDAL)
        {
            _OpenHoursDAL = OpenHoursDAL;
        }

        public void TCreate(OpenHours entity)
        {
            _OpenHoursDAL.Create(entity);
        }

        public void TDelete(OpenHours entity)
        {
            _OpenHoursDAL.Delete(entity);
        }

        public List<OpenHours> TGetAll()
        {
            return _OpenHoursDAL.GetListAll();
        }

        public OpenHours TGetById(int id)
        {
            return _OpenHoursDAL.GetById(id);
        }

        public void TUpdate(OpenHours entity)
        {
            _OpenHoursDAL.Update(entity);
        }
    }
}
