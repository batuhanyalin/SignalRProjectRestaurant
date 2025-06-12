using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities.Concrete;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCaseController : ControllerBase
    {
        private readonly IMoneyCaseService _MoneyCaseService;
        private readonly IMapper _mapper;

        public MoneyCaseController(IMoneyCaseService MoneyCaseService, IMapper mapper)
        {
            _MoneyCaseService = MoneyCaseService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult TotalMoneyCaseAmount()
        {
            return Ok(_MoneyCaseService.TTotalMoneyCaseAmount());
        }    
    }
}
