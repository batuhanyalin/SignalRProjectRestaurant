using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.OrderDetailDto;
using SignalR.EntityLayer.Entities.Concrete;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _OrderDetailService;
        private readonly IMapper _mapper;

        public OrderDetailController(IOrderDetailService OrderDetailService, IMapper mapper)
        {
            _OrderDetailService = OrderDetailService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetOrderDetailList()
        {
            var values = _OrderDetailService.TGetAll();
            var map = _mapper.Map<List<ResultOrderDetailDto>>(values);
            return Ok(map);
        }
        [HttpGet("GetByIdOrderDetail/{id}")]
        public IActionResult GetByIdOrderDetail(int id)
        {
            var value = _OrderDetailService.TGetById(id);
            var map = _mapper.Map<GetByIdOrderDetailDto>(value);
            return Ok(map);
        }
        [HttpPut]
        public IActionResult UpdateOrderDetail(UpdateOrderDetailDto dto)
        {
            var map = _mapper.Map<OrderDetail>(dto);
            _OrderDetailService.TUpdate(map);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpPost]
        public IActionResult CreateOrderDetail(CreateOrderDetailDto dto)
        {
            var map = _mapper.Map<OrderDetail>(dto);
            _OrderDetailService.TCreate(map);
            return Ok("Veri başarıyla kaydedildi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteOrderDetail(int id)
        {
            var value = _OrderDetailService.TGetById(id);
            _OrderDetailService.TDelete(value);
            return Ok("Veri başarıyla silindi.");
        }
    }
}
