using Courses.models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {     
        private readonly IDataContext _context;
        public StudentsController(IDataContext context)
        {
            _context = context;
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public List<Student> Get()
        {
            return _context.students;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            //return _context.students.FirstOrDefault(f => f.Id == id);
            var stud = _context.students.Find(u => u.Id == id);
            if (stud is null)
            {
                return NotFound();
            }
            return Ok(stud);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            //foreach (Course item in courses)
            //{

            //}
            _context.students.Add(value);
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] int value)
        {
            foreach (Student item in _context.students)
            {
                if (item.Id == id)
                {
                    item.CodeCourse = value;
                    return;
                }
            }
        }
        // PUT api/<StudentsController>/5
        [HttpPut]
        public void Put(int id)
        {
            foreach (Student item in _context.students)
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

        // DELETE api/<StudentsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
