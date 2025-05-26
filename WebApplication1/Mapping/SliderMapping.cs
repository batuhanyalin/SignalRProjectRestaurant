using AutoMapper;
using SignalR.DtoLayer.SliderDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Mapping
{
    public class SliderMapping:Profile
    {
        public SliderMapping()
        {
            CreateMap<Slider,ResultSliderDto>().ReverseMap();
            CreateMap<Slider,GetByIdSliderDto>().ReverseMap();
            CreateMap<Slider,CreateSliderDto>().ReverseMap();
            CreateMap<Slider,UpdateSliderDto>().ReverseMap();
        }
    }
}
