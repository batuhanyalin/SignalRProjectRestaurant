using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.DtoLayer.ContactUsDto;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProjectRestaurant.WebUI.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactUsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7197/api/ContactUs/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactUsDto>>(jsonData);
                var id = values.Select(x => x.ContactUsId).FirstOrDefault();
                var responseMessage2 = await client.GetAsync($"https://localhost:7197/api/ContactUs/GetByIdContactUs/{id}");

                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateContactUsDto>(jsonData2);
                return View(value);
            }
            return RedirectToAction("Index","Dashboard");
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateContactUsDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7197/api/ContactUs", content);
            if (responseMessage.IsSuccessStatusCode) 
            {
                return RedirectToAction("Index", "Dashboard");
            }
            return View(dto);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7197/api/ContactUs/{id}");
            if (responseMessage.IsSuccessStatusCode) 
            {
                return RedirectToAction("Index", "Dashboard");
            }
            return RedirectToAction("Index");
        }
    }
}
