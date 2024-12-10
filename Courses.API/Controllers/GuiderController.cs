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
    public class GuiderController : ControllerBase
    {
        private readonly IGuideService _context;
        public GuiderController(IGuideService context)
        {
            _context = context;
        }
        // GET: api/<GuiderController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.GetList());
        }

        // GET api/<GuiderController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_context.GetById(id));
        }

        // POST api/<GuiderController>
        [HttpPost]
        public void Post([FromBody] Guide value)
        {
            _context.Add(value);
        }

        // PUT api/<GuiderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Guide guide)
        {
            _context.Update(id, guide);
        }
        // PUT api/<GuiderController>/5
        [HttpPut]
        public void Put(int id,bool status)
        {
            _context.UpdateStatus(id,status);
        }

        // DELETE api/<GuiderController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
