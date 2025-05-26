using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _CategoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService CategoryService, IMapper mapper)
        {
            _CategoryService = CategoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCategoryList()
        {
            var values = _CategoryService.TGetAll();
            var map = _mapper.Map<ResultCategoryDto>(values);
            return Ok(map);
        }
        [HttpGet("GetByIdCategory")]
        public IActionResult GetByIdCategory(int id)
        {
            var value = _CategoryService.TGetById(id);
            var map = _mapper.Map<GetByIdCategoryDto>(value);
            return Ok(map);
        }
        [HttpPost]
        public IActionResult UpdateCategory(UpdateCategoryDto dto)
        {
            var map = _mapper.Map<Category>(dto);
            _CategoryService.TUpdate(map);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpPut]
        public IActionResult CreateCategory(CreateCategoryDto dto)
        {
            var map = _mapper.Map<Category>(dto);
            _CategoryService.TCreate(map);
            return Ok("Veri başarıyla kaydedildi.");
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var value = _CategoryService.TGetById(id);
            _CategoryService.TDelete(value);
            return Ok("Veri başarıyla silindi.");
        }
    }
}
