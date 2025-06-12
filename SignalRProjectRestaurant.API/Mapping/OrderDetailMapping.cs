using AutoMapper;
using SignalR.DtoLayer.OrderDetailDto;
using SignalR.EntityLayer.Entities.Concrete;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Mapping
{
    public class OrderDetailMapping:Profile
    {
        public OrderDetailMapping()
        {
            CreateMap<OrderDetail,ResultOrderDetailDto>().ReverseMap();
            CreateMap<OrderDetail,GetByIdOrderDetailDto>().ReverseMap();
            CreateMap<OrderDetail,CreateOrderDetailDto>().ReverseMap();
            CreateMap<OrderDetail,UpdateOrderDetailDto>().ReverseMap();
        }
    }
}
