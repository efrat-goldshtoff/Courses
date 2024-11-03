using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        public static List<Course> courses = new List<Course>();
        // GET: api/<CoursesController>
        [HttpGet]
        public List<Course> Get()
        {
            return courses;
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public Course Get(int id)
        {
            return courses.FirstOrDefault(f => f.Id == id);
        }

        // POST api/<CoursesController>
        [HttpPost]
        public void Post([FromBody] Course value)
        {
            courses.Add(value);
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            foreach (Course item in courses)
            {
                if (item.Id == id)
                {
                    item.Subject = value;
                    return;
                }
            }
        } 
        [HttpPut]
        public void Put(int id)
        {

        }

        // DELETE api/<CoursesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
