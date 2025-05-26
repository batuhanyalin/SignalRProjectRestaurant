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
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDAL _ContactUsDAL;

        public ContactUsManager(IContactUsDAL ContactUsDAL)
        {
            _ContactUsDAL = ContactUsDAL;
        }

        public void TCreate(ContactUs entity)
        {
            _ContactUsDAL.Create(entity);
        }

        public void TDelete(ContactUs entity)
        {
            _ContactUsDAL.Delete(entity);
        }

        public List<ContactUs> TGetAll()
        {
            return _ContactUsDAL.GetListAll();
        }

        public ContactUs TGetById(int id)
        {
            return _ContactUsDAL.GetById(id);
        }

        public void TUpdate(ContactUs entity)
        {
            _ContactUsDAL.Update(entity);
        }
    }
}
