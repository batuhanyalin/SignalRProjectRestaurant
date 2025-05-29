using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.DtoLayer.AboutDto;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProjectRestaurant.WebUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.GetAsync("https://localhost:7197/api/About");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var value2 = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData2);
            var about = value2.FirstOrDefault();
            int id = about.AboutId;

            var responseMessage = await client.GetAsync($"https://localhost:7197/api/About/GetByIdAbout/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateAboutDto>(jsonData);
                return View(values);
            }
            return RedirectToAction("Index", "Dashboard");
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateAboutDto dto, IFormFile ImageUpload)
        {
            if (ImageUpload != null && ImageUpload.Length > 0)
            {
                var source = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(ImageUpload.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = Path.Combine(source, "wwwroot/images/pages", imageName);

                using (var stream = new FileStream(saveLocation, FileMode.Create))
                {
                    await ImageUpload.CopyToAsync(stream);
                }
                dto.ImageUrl = $"/images/pages/{imageName}";
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7197/api/About/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
