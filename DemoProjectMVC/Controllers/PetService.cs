//using Newtonsoft.Json;
//using System.Text;

//namespace DemoProjectMVC.Controllers
//{
//    public class PetService
//    {
//        private readonly HttpClient _httpClient;

//        public PetService()
//        {
//            _httpClient = new HttpClient();
//            _httpClient.BaseAddress = new Uri("http://localhost:5281/api/PetAnimals");
//            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
//        }

//        public async Task CreatePet(Models.Pet pet)
//        {
//            var json = JsonConvert.SerializeObject(pet);
//            var content = new StringContent(json, Encoding.UTF8, "application/json");
//            await _httpClient.PostAsync("pet", content);
//        }
//    }
//}
