using System.Collections.Generic;
using System.Text.Json;
using DemoProjectAPI.Models;
//using DemoProjectMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoProjectMVC.Controllers
{
    public class PetController : Controller
    {

        // GET: PetController
        public ActionResult Index()
        {
            IEnumerable<PetAnimal> pets= null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5281/api/PetAnimals");
                //HTTP GET
                var responseTask = client.GetAsync("PetAnimals");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadFromJsonAsync<IList <PetAnimal>> ();
                    readTask.Wait();

                    pets = readTask.Result;
                }
            }
            
                return View(pets);
            
        }

        // GET: PetController/Details/5
        public ActionResult Details()
        {
            PetAnimal pet = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5281/api/PetAnimals");
                var response = client.GetAsync("PetAnimals").Result;

                if (response.IsSuccessStatusCode)
                {
                   // pet = JsonSerializer.Deserialize(response.Content.ReadFromJsonAsync<PetAnimal>()).Result;
                }
            }

            return View(pet);
        }

        // GET: PetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("petId, petName, petType, gender, IsVeg")] PetAnimal petAnimal)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5281/api/PetAnimals");
                    var postTask = client.PostAsJsonAsync("PetAnimals", petAnimal);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Error creating pet animal.");
                    }
                }
            }
            return View(petAnimal);
        }

        // GET: PetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PetController/Edit/5
        // [HttpPut]
        [HttpPut("PetAnimals/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int petId, [Bind("petId, petName, petType, gender, IsVeg")] PetAnimal petAnimal)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5281/api/PetAnimals");

                    // HTTP PUT to update
                    var putTask = client.PutAsJsonAsync("PetAnimals", petAnimal);
                    putTask.Wait();

                    var result = putTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Error updating pet animal.");
                    }
                }
            }
            return View(petAnimal);
        }

        // GET: PetController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: PetController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        public ActionResult Delete()
        {
            PetAnimal pet = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5281/api/PetAnimals");
                var response = client.GetAsync("PetAnimals").Result;

                if (response.IsSuccessStatusCode)
                {
                    pet = response.Content.ReadFromJsonAsync<PetAnimal>().Result;
                }
            }

            return View(pet);
        }

        // POST: PetController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5281/api/PetAnimals");

                // HTTP DELETE to delete
                var deleteTask = client.DeleteAsync($"PetAnimals/");
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Error deleting pet animal.");
                }
            }

            return RedirectToAction("Index");
        }
    }
}
