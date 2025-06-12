using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ClientTableDto;
using SignalR.EntityLayer.Entities.Concrete;

namespace SignalRProjectRestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientTableController : ControllerBase
    {
        private readonly IClientTableService _ClientTableService;
        private readonly IMapper _mapper;

        public ClientTableController(IClientTableService ClientTableService, IMapper mapper)
        {
            _ClientTableService = ClientTableService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetClientTableList()
        {
            var values = _ClientTableService.TGetAll();
            var map = _mapper.Map<List<ResultClientTableDto>>(values);
            return Ok(map);
        }
        [HttpGet("GetByIdClientTable/{id}")]
        public IActionResult GetByIdClientTable(int id)
        {
            var value = _ClientTableService.TGetById(id);
            var map = _mapper.Map<GetByIdClientTableDto>(value);
            return Ok(map);
        }
        [HttpPut]
        public IActionResult UpdateClientTable(UpdateClientTableDto dto)
        {
            var map = _mapper.Map<ClientTable>(dto);
            _ClientTableService.TUpdate(map);
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpPost]
        public IActionResult CreateClientTable(CreateClientTableDto dto)
        {
            var map = _mapper.Map<ClientTable>(dto);
            _ClientTableService.TCreate(map);
            return Ok("Veri başarıyla kaydedildi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteClientTable(int id)
        {
            var value = _ClientTableService.TGetById(id);
            _ClientTableService.TDelete(value);
            return Ok("Veri başarıyla silindi.");
        }    
        
        [HttpGet("ClientTableCount")]
        public IActionResult ClientTableCount()
        {      
            return Ok(_ClientTableService.TClientTableCount());
        }
    }
}
