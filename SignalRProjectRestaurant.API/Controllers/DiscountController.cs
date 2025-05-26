using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _DiscountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService DiscountService, IMapper mapper)
        {
            _DiscountService = DiscountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetDiscountList()
        {
            var values = _DiscountService.TGetAll();
            var map = _mapper.Map< List<ResultDiscountDto>>(values);
            return Ok(map);
        }
        [HttpGet("GetByIdDiscount")]
        public IActionResult GetByIdDiscount(int id)
        {
            var value = _DiscountService.TGetById(id);
            var map = _mapper.Map<GetByIdDiscountDto>(value);
            return Ok(map);
        }
        [HttpPost]
        public IActionResult UpdateDiscount(UpdateDiscountDto dto)
        {
            var map = _mapper.Map<Discount>(dto);
            _DiscountService.TUpdate(map);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpPut]
        public IActionResult CreateDiscount(CreateDiscountDto dto)
        {
            var map = _mapper.Map<Discount>(dto);
            _DiscountService.TCreate(map);
            return Ok("Veri başarıyla kaydedildi.");
        }
        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _DiscountService.TGetById(id);
            _DiscountService.TDelete(value);
            return Ok("Veri başarıyla silindi.");
        }
    }
}
