using Courses.Core;
using Courses.Core.models;
using Courses.Core.Services;
using Courses.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Courses.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICoursesService _context;
        public CoursesController(ICoursesService context)
        {
            _context = context;
        }
        // GET: api/<CoursesController>
        [HttpGet]
        public ActionResult Get()
        {
            var courses = _context.GetList();
            return Ok(courses);
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var courses = _context.GetById(id);
            return Ok(courses);
        }

        // POST api/<CoursesController>
        [HttpPost]
        public void Post([FromBody] Course value)
        {
            _context.Add(value);
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Course value)
        {
            _context.Update(id, value);

        }
        [HttpPut]
        public void Put(int id,bool status)
        {
            _context.UpdateStatus(id, status);
        }

        // DELETE api/<CoursesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
