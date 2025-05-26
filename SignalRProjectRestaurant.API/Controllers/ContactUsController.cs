using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ContactUsDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly IContactUsService _ContactUsService;
        private readonly IMapper _mapper;

        public ContactUsController(IContactUsService ContactUsService, IMapper mapper)
        {
            _ContactUsService = ContactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetContactUsList()
        {
            var values = _ContactUsService.TGetAll();
            var map = _mapper.Map< List<ResultContactUsDto>>(values);
            return Ok(map);
        }
        [HttpGet("GetByIdContactUs")]
        public IActionResult GetByIdContactUs(int id)
        {
            var value = _ContactUsService.TGetById(id);
            var map = _mapper.Map<GetByIdContactUsDto>(value);
            return Ok(map);
        }
        [HttpPost]
        public IActionResult UpdateContactUs(UpdateContactUsDto dto)
        {
            var map = _mapper.Map<ContactUs>(dto);
            _ContactUsService.TUpdate(map);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpPut]
        public IActionResult CreateContactUs(CreateContactUsDto dto)
        {
            var map = _mapper.Map<ContactUs>(dto);
            _ContactUsService.TCreate(map);
            return Ok("Veri başarıyla kaydedildi.");
        }
        [HttpDelete]
        public IActionResult DeleteContactUs(int id)
        {
            var value = _ContactUsService.TGetById(id);
            _ContactUsService.TDelete(value);
            return Ok("Veri başarıyla silindi.");
        }
    }
}
