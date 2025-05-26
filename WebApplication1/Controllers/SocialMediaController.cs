using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _SocialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService SocialMediaService, IMapper mapper)
        {
            _SocialMediaService = SocialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetSocialMediaList()
        {
            var values = _SocialMediaService.TGetAll();
            var map = _mapper.Map<ResultSocialMediaDto>(values);
            return Ok(map);
        }
        [HttpGet("GetByIdSocialMedia")]
        public IActionResult GetByIdSocialMedia(int id)
        {
            var value = _SocialMediaService.TGetById(id);
            var map = _mapper.Map<GetByIdSocialMediaDto>(value);
            return Ok(map);
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto dto)
        {
            var map = _mapper.Map<SocialMedia>(dto);
            _SocialMediaService.TUpdate(map);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpPut]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto dto)
        {
            var map = _mapper.Map<SocialMedia>(dto);
            _SocialMediaService.TCreate(map);
            return Ok("Veri başarıyla kaydedildi.");
        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _SocialMediaService.TGetById(id);
            _SocialMediaService.TDelete(value);
            return Ok("Veri başarıyla silindi.");
        }
    }
}
