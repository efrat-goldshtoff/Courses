using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuiderController : ControllerBase
    {
        static List<Guide> guiders = new List<Guide>();
        // GET: api/<GuiderController>
        [HttpGet]
        public List<Guide> Get()
        {
            return guiders;
        }

        // GET api/<GuiderController>/5
        [HttpGet("{id}")]
        public Guide Get(int id)
        {
            return guiders.FirstOrDefault(f => f.Id == id);
        }

        // POST api/<GuiderController>
        [HttpPost]
        public void Post([FromBody] Guide value)
        {
            guiders.Add(value);
        }

        // PUT api/<GuiderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string name)
        {
            foreach (Guide item in guiders)
            {
                if (item.Id == id)
                {
                    item.Name = name;
                    return;
                }
            }
        }
        // PUT api/<GuiderController>/5
        [HttpPut]
        public void Put(int id)
        {
            foreach (Guide item in guiders)
            {
                if (item.Id == id)
                {
                    if (item.IsActive == true)
                        item.IsActive = false;
                    else if (item.IsActive == false)
                        item.IsActive = true;
                }
            }
        }

        // DELETE api/<GuiderController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
