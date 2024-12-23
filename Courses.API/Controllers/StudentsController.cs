using AutoMapper;
using Courses.API.models;
using Courses.Core;
using Courses.Core.DTOs;
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
        //private readonly Mapping _mapping;
        private readonly IMapper _mapper;
        public StudentsController(IStudentService context, IMapper mappre)
        {
            _context = context;
            _mapper = mappre;

        }
        // GET: api/<StudentsController>
        [HttpGet]
        public ActionResult Get()
        {
            var studs = _context.GetList();
            var listDTO = _mapper.Map<IEnumerable<StudentDto>>(studs);
            return Ok(listDTO);
            //var listDTO = new List<StudentDto>();
            //foreach (var value in studs)
            //{
            //    //listDTO.Add(_mapping.MapToStudentDto(value));
            //    listDTO.Add(_mapper.Map<StudentDto>(value));
            //}
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var value = _context.GetById(id);
            //var sDTO = _mapping.MapToStudentDto(value);
            var sDTO = _mapper.Map<StudentDto>(value);
            return Ok(sDTO);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] StudentPostModel value)
        {
            var s = new Student { Name = value.Name };
            _context.Add(s);
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StudentPostModel value)
        {
            var s = new Student { Name = value.Name };
            _context.Update(id, s);
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
