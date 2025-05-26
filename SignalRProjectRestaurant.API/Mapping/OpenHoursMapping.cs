using AutoMapper;
using SignalR.DtoLayer.OpenHoursDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Mapping
{
    public class OpenHoursMapping:Profile
    {
        public OpenHoursMapping()
        {
            CreateMap<OpenHours,ResultOpenHoursDto>().ReverseMap();
            CreateMap<OpenHours,GetByIdOpenHoursDto>().ReverseMap();
            CreateMap<OpenHours,CreateOpenHoursDto>().ReverseMap();
            CreateMap<OpenHours,UpdateOpenHoursDto>().ReverseMap();
        }
    }
}
