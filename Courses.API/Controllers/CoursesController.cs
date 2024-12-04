using Courses.Core;
using Courses.Core.models;
using Courses.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Courses.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly CourseService _context;
        //private readonly IDataContext _context;
        public CoursesController(CourseService context)
        {
            _context = context;
        }
        // GET: api/<CoursesController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _context.GetAll();
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public Course Get(int id)
        {
            return _context.courses.FirstOrDefault(f => f.Id == id);
        }

        // POST api/<CoursesController>
        [HttpPost]
        public void Post([FromBody] Course value)
        {
            _context.courses.Add(value);
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            foreach (Course item in _context.courses)
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
