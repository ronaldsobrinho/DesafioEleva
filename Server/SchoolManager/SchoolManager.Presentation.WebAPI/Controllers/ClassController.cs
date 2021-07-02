using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SchoolManager.Application.Service;
using SchoolManager.Domain.Models;

namespace SchoolManager.Presentation.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private IClassService _service;
        public ClassController(IClassService service) {
            _service = service;
        }
        // GET: Class/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)        
        {
            IActionResult result;
            
            try
            {
                result =  Ok(_service.GetAll(id));
            }
            catch (System.Exception ex)
            {
                result = BadRequest(ex.Message);
                
            }
            return result;
        }

        // POST: api/Class
        [HttpPost]
        public IActionResult Post([FromBody] ClassModel classModel)
        {
            _service.Add(classModel);
            return Ok();
        }

        //// PUT: api/Class/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] ClassModel classModel)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
