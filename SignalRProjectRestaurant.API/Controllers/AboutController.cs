using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAboutList()
        {
            var values = _aboutService.TGetAll();
            var map = _mapper.Map<List<ResultAboutDto>>(values);
            return Ok(map);
        }
        [HttpGet("GetByIdAbout")]
        public IActionResult GetByIdAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            var map = _mapper.Map<GetByIdAboutDto>(value);
            return Ok(map);
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto dto)
        {
            var map = _mapper.Map<About>(dto);
            _aboutService.TUpdate(map);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto dto)
        {
            var map = _mapper.Map<About>(dto);
            _aboutService.TCreate(map);
            return Ok("Veri başarıyla kaydedildi.");
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            _aboutService.TDelete(value);
            return Ok("Veri başarıyla silindi.");
        }
    }
}
