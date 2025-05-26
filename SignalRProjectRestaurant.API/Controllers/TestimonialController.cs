using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.TestimonialDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _TestimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService TestimonialService, IMapper mapper)
        {
            _TestimonialService = TestimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetTestimonialList()
        {
            var values = _TestimonialService.TGetAll();
            var map = _mapper.Map< List<ResultTestimonialDto>>(values);
            return Ok(map);
        }
        [HttpGet("GetByIdTestimonial")]
        public IActionResult GetByIdTestimonial(int id)
        {
            var value = _TestimonialService.TGetById(id);
            var map = _mapper.Map<GetByIdTestimonialDto>(value);
            return Ok(map);
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto dto)
        {
            var map = _mapper.Map<Testimonial>(dto);
            _TestimonialService.TUpdate(map);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpPut]
        public IActionResult CreateTestimonial(CreateTestimonialDto dto)
        {
            var map = _mapper.Map<Testimonial>(dto);
            _TestimonialService.TCreate(map);
            return Ok("Veri başarıyla kaydedildi.");
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _TestimonialService.TGetById(id);
            _TestimonialService.TDelete(value);
            return Ok("Veri başarıyla silindi.");
        }
    }
}
