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
    public class SliderManager : ISliderService
    {
        private readonly ISliderDAL _SliderDAL;

        public SliderManager(ISliderDAL SliderDAL)
        {
            _SliderDAL = SliderDAL;
        }

        public void TCreate(Slider entity)
        {
            _SliderDAL.Create(entity);
        }

        public void TDelete(Slider entity)
        {
            _SliderDAL.Delete(entity);
        }

        public List<Slider> TGetAll()
        {
            return _SliderDAL.GetListAll();
        }

        public Slider TGetById(int id)
        {
            return _SliderDAL.GetById(id);
        }

        public void TUpdate(Slider entity)
        {
            _SliderDAL.Update(entity);
        }
    }
}
