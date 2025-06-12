using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.OrderDto;
using SignalR.EntityLayer.Entities.Concrete;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _OrderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService OrderService, IMapper mapper)
        {
            _OrderService = OrderService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetOrderList()
        {
            var values = _OrderService.TGetAll();
            var map = _mapper.Map<List<ResultOrderDto>>(values);
            return Ok(map);
        }
        [HttpGet("GetByIdOrder/{id}")]
        public IActionResult GetByIdOrder(int id)
        {
            var value = _OrderService.TGetById(id);
            var map = _mapper.Map<GetByIdOrderDto>(value);
            return Ok(map);
        }
        [HttpPut]
        public IActionResult UpdateOrder(UpdateOrderDto dto)
        {
            var map = _mapper.Map<Order>(dto);
            _OrderService.TUpdate(map);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpPost]
        public IActionResult CreateOrder(CreateOrderDto dto)
        {
            var map = _mapper.Map<Order>(dto);
            _OrderService.TCreate(map);
            return Ok("Veri başarıyla kaydedildi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var value = _OrderService.TGetById(id);
            _OrderService.TDelete(value);
            return Ok("Veri başarıyla silindi.");
        }

        [HttpGet("TotalOrderCount")]
        public IActionResult TotalOrderCount()
        {    
            return Ok(_OrderService.TTotalOrderCount());
        }
        [HttpGet("ActiveOrderCount")]
        public IActionResult ActiveOrderCount()
        {
            return Ok(_OrderService.TActiveOrderCount());
        }
        [HttpGet("PassiveOrderCount")]
        public IActionResult PassiveOrderCount()
        {
            return Ok(_OrderService.TPassiveOrderCount());
        }
        [HttpGet("LastOrderPrice")]
        public IActionResult LastOrderPrice()
        {
            return Ok(_OrderService.TLastOrderPrice());
        }
        [HttpGet("TodayTotalPrice")]
        public IActionResult TodayTotalPrice()
        {
            return Ok(_OrderService.TTodayTotalPrice());
        }
    }
}
