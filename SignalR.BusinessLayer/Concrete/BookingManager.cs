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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDAL _BookingDAL;

        public BookingManager(IBookingDAL BookingDAL)
        {
            _BookingDAL = BookingDAL;
        }

        public void TCreate(Booking entity)
        {
            _BookingDAL.Create(entity);
        }

        public void TDelete(Booking entity)
        {
            _BookingDAL.Delete(entity);
        }

        public List<Booking> TGetAll()
        {
            return _BookingDAL.GetListAll();
        }

        public Booking TGetById(int id)
        {
            return _BookingDAL.GetById(id);
        }

        public void TUpdate(Booking entity)
        {
            _BookingDAL.Update(entity);
        }
    }
}
