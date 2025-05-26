using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _BookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService BookingService, IMapper mapper)
        {
            _BookingService = BookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetBookingList()
        {
            var values = _BookingService.TGetAll();
            var map = _mapper.Map<ResultBookingDto>(values);
            return Ok(map);
        }
        [HttpGet("GetByIdBooking")]
        public IActionResult GetByIdBooking(int id)
        {
            var value = _BookingService.TGetById(id);
            var map = _mapper.Map<GetByIdBookingDto>(value);
            return Ok(map);
        }
        [HttpPost]
        public IActionResult UpdateBooking(UpdateBookingDto dto)
        {
            var map = _mapper.Map<Booking>(dto);
            _BookingService.TUpdate(map);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpPut]
        public IActionResult CreateBooking(CreateBookingDto dto)
        {
            var map = _mapper.Map<Booking>(dto);
            _BookingService.TCreate(map);
            return Ok("Veri başarıyla kaydedildi.");
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _BookingService.TGetById(id);
            _BookingService.TDelete(value);
            return Ok("Veri başarıyla silindi.");
        }
    }
}
