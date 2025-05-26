using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SliderDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderService _SliderService;
        private readonly IMapper _mapper;

        public SliderController(ISliderService SliderService, IMapper mapper)
        {
            _SliderService = SliderService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetSliderList()
        {
            var values = _SliderService.TGetAll();
            var map = _mapper.Map<ResultSliderDto>(values);
            return Ok(map);
        }
        [HttpGet("GetByIdSlider")]
        public IActionResult GetByIdSlider(int id)
        {
            var value = _SliderService.TGetById(id);
            var map = _mapper.Map<GetByIdSliderDto>(value);
            return Ok(map);
        }
        [HttpPost]
        public IActionResult UpdateSlider(UpdateSliderDto dto)
        {
            var map = _mapper.Map<Slider>(dto);
            _SliderService.TUpdate(map);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpPut]
        public IActionResult CreateSlider(CreateSliderDto dto)
        {
            var map = _mapper.Map<Slider>(dto);
            _SliderService.TCreate(map);
            return Ok("Veri başarıyla kaydedildi.");
        }
        [HttpDelete]
        public IActionResult DeleteSlider(int id)
        {
            var value = _SliderService.TGetById(id);
            _SliderService.TDelete(value);
            return Ok("Veri başarıyla silindi.");
        }
    }
}
