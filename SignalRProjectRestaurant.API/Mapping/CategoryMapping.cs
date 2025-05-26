using AutoMapper;
using SignalR.DtoLayer.CategoryDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
            CreateMap<Category,GetByIdCategoryDto>().ReverseMap();
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();
            CreateMap<Category,ResultCategoryWithProductCount>().ReverseMap();
        }
    }
}
