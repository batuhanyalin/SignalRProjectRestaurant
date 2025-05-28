using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;
        private readonly IMapper _mapper;

        public ProductController(IProductService ProductService, IMapper mapper)
        {
            _ProductService = ProductService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetProductList()
        {
            var values = _ProductService.TGetProductsWithCategories();
            //var map = _mapper.Map<List<ResultProductDto>>(values);
            return Ok(values);
        }
        [HttpGet("GetByIdProduct/{id}")]
        public IActionResult GetByIdProduct(int id)
        {
            var value = _ProductService.TGetById(id);
            var map = _mapper.Map<GetByIdProductDto>(value);
            return Ok(map);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto dto)
        {
            var map = _mapper.Map<Product>(dto);
            _ProductService.TUpdate(map);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto dto)
        {
            var map = _mapper.Map<Product>(dto);
            _ProductService.TCreate(map);
            return Ok("Veri başarıyla kaydedildi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _ProductService.TGetById(id);
            _ProductService.TDelete(value);
            return Ok("Veri başarıyla silindi.");
        }
        [HttpGet("ChangeStatus/{id}")]
        public IActionResult ChangeStatus(int id)
        {
            _ProductService.TChangeStatus(id);
            return Ok("Durum başarıyla güncellendi.");
        }
    }
}
