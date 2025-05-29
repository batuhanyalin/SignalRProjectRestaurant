using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.DtoLayer.DiscountDto;
using System.Text;

namespace SignalRProjectRestaurant.WebUI.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DiscountController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7197/api/Discount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultDiscountDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateDiscountDto dto, IFormFile ImageUpload)
        {
            if (ImageUpload != null && ImageUpload.Length > 0)
            {
                var source = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(ImageUpload.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = Path.Combine(source, "wwwroot/images/discountProduct", imageName);
                using (var stream = new FileStream(saveLocation, FileMode.Create))
                {
                    await ImageUpload.CopyToAsync(stream);
                }
                dto.ImageUrl = $"/images/discountProduct/{imageName}";
            }
            else
            {
                dto.ImageUrl = $"/images/products/no-image.jpg";
            }


            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7197/api/Discount", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(dto);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7197/api/Discount/GetByIdDiscount/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateDiscountDto>(jsonData);
                return View(value);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateDiscountDto dto, IFormFile ImageUpload)
        {
            if (ImageUpload != null && ImageUpload.Length > 0)
            {


                var source = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(ImageUpload.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = Path.Combine(source, "wwwroot/images/discountProduct", imageName);
                using (var stream = new FileStream(saveLocation, FileMode.Create))
                {
                    await ImageUpload.CopyToAsync(stream);
                }
                dto.ImageUrl = $"/images/discountProduct/{imageName}";
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7197/api/Discount", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7197/api/Discount/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }

        }
    }
}
