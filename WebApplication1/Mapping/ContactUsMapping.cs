using AutoMapper;
using SignalR.DtoLayer.ContactUsDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Mapping
{
    public class ContactUsMapping:Profile
    {
        public ContactUsMapping()
        {
            CreateMap<ContactUs,ResultContactUsDto>().ReverseMap();
            CreateMap<ContactUs,GetByIdContactUsDto>().ReverseMap();
            CreateMap<ContactUs,CreateContactUsDto>().ReverseMap();
            CreateMap<ContactUs,UpdateContactUsDto>().ReverseMap();
        }
    }
}
