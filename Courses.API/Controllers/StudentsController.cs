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
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _context;
        public StudentsController(IStudentService context)
        {
            _context = context;
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.GetList());
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_context.GetById(id));
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            _context.Add(value);
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
            _context.Update(id, value);
            //foreach (Student item in _context.GetAll())
            //{
            //    if (item.Id == id)
            //    {
            //        item.CodeCourse = value;
            //        return;
            //    }
            //}
        }
        // PUT api/<StudentsController>/5
        [HttpPut]
        public void Put(int id, bool status)
        {
            _context.UpdateStatus(id, status);
            //foreach (Student item in _context.GetAll())
            //{
            //    if (item.Id == id)
            //    {
            //        if (item.IsActive == true)
            //            item.IsActive = false;
            //        else if (item.IsActive == false)
            //            item.IsActive = true;
            //    }
            //}
        }

        // DELETE api/<StudentsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
