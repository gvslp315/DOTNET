using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        // GET: api/<MoviesController>
        IList<string> countries=new List<string>() { "Pushpa", "Vikram", "Bhahubali", "Salaar", "Kantara" };
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return countries.ToList();
            //return new string[] { "Pushpa", "Vikram","Bhahubali","Salaar","Kantara" };
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

            return countries[id];
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            countries.Add(value);
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
           countries[id] = value;
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            countries.RemoveAt(id);

        }
    }
}
