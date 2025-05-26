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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDAL _TestimonialDAL;

        public TestimonialManager(ITestimonialDAL TestimonialDAL)
        {
            _TestimonialDAL = TestimonialDAL;
        }

        public void TCreate(Testimonial entity)
        {
            _TestimonialDAL.Create(entity);

        }

        public void TDelete(Testimonial entity)
        {
            _TestimonialDAL.Delete(entity);
        }

        public List<Testimonial> TGetAll()
        {
            return _TestimonialDAL.GetListAll();
        }

        public Testimonial TGetById(int id)
        {
           return _TestimonialDAL.GetById(id);
        }

        public void TUpdate(Testimonial entity)
        {
            _TestimonialDAL.Update(entity);
        }
    }
}
