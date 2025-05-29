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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDAL _SocialMediaDAL;

        public SocialMediaManager(ISocialMediaDAL SocialMediaDAL)
        {
            _SocialMediaDAL = SocialMediaDAL;
        }

        public void TChangeStatus(int id)
        {
            _SocialMediaDAL.ChangeStatus(id);
        }

        public void TCreate(SocialMedia entity)
        {
            _SocialMediaDAL.Create(entity);
        }

        public void TDelete(SocialMedia entity)
        {
            _SocialMediaDAL.Delete(entity);
        }

        public List<SocialMedia> TGetAll()
        {
            return _SocialMediaDAL.GetListAll();
        }

        public SocialMedia TGetById(int id)
        {
            return _SocialMediaDAL.GetById(id);
        }

        public void TUpdate(SocialMedia entity)
        {
            _SocialMediaDAL.Update(entity);
        }
    }
}
