using Microsoft.AspNetCore.Mvc;
using SchoolManager.Application.Service;
using SchoolManager.Domain.Model;

namespace SchoolManager.Presentation.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolService _service;
        
        public SchoolController(ISchoolService service)
        {
            _service = service; 
        }

        // GET: api/School
        [HttpGet]
        public IActionResult GetAllSchools()
        {
            IActionResult result; 
                     
            try
            {
                result =  Ok(_service.GetAll());
            }
            catch (System.Exception ex)
            {
                result = BadRequest(ex.Message);
            }
            return result;
        }
        
        //// POST: api/School        
        [HttpPost]
        public IActionResult PostSchoolModel([FromBody]  SchoolModel schoolModel)
        {
            _service.Add(schoolModel);                        
            return Ok();
        }                
    }
}
