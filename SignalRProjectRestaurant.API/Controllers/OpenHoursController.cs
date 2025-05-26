using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.OpenHoursDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenHoursController : ControllerBase
    {
        private readonly IOpenHoursService _OpenHoursService;
        private readonly IMapper _mapper;

        public OpenHoursController(IOpenHoursService OpenHoursService, IMapper mapper)
        {
            _OpenHoursService = OpenHoursService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetOpenHoursList()
        {
            var values = _OpenHoursService.TGetAll();
            var map = _mapper.Map< List<ResultOpenHoursDto>>(values);
            return Ok(map);
        }
        [HttpGet("GetByIdOpenHours")]
        public IActionResult GetByIdOpenHours(int id)
        {
            var value = _OpenHoursService.TGetById(id);
            var map = _mapper.Map<GetByIdOpenHoursDto>(value);
            return Ok(map);
        }
        [HttpPost]
        public IActionResult UpdateOpenHours(UpdateOpenHoursDto dto)
        {
            var map = _mapper.Map<OpenHours>(dto);
            _OpenHoursService.TUpdate(map);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpPut]
        public IActionResult CreateOpenHours(CreateOpenHoursDto dto)
        {
            var map = _mapper.Map<OpenHours>(dto);
            _OpenHoursService.TCreate(map);
            return Ok("Veri başarıyla kaydedildi.");
        }
        [HttpDelete]
        public IActionResult DeleteOpenHours(int id)
        {
            var value = _OpenHoursService.TGetById(id);
            _OpenHoursService.TDelete(value);
            return Ok("Veri başarıyla silindi.");
        }
    }
}
