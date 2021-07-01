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
            //todo: adequar fluxo de erro
            return  Ok(_service.GetAll());
        }

        //// GET: api/School/5
        //[HttpGet("{id}")]
        //public IActionResult GetSchoolModel(int id)
        //{
        //    var schoolModel = await _context.SchoolModel.FindAsync(id);

        //    if (schoolModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return schoolModel;
        //}

        //// POST: api/School        
        [HttpPost]
        public IActionResult PostSchoolModel([FromBody]  SchoolModel schoolModel)
        {
            _service.Add(schoolModel);            
            //return CreatedAtAction("GetSchoolModel", new { id = schoolModel.Id }, schoolModel);
            return Ok();
        }
        
        //// PUT: api/School/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSchoolModel(int id, SchoolModel schoolModel)
        //{
        //    if (id != schoolModel.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(schoolModel).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SchoolModelExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}



        //// DELETE: api/School/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<SchoolModel>> DeleteSchoolModel(int id)
        //{
        //    var schoolModel = await _context.SchoolModel.FindAsync(id);
        //    if (schoolModel == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.SchoolModel.Remove(schoolModel);
        //    await _context.SaveChangesAsync();

        //    return schoolModel;
        //}

        //private bool SchoolModelExists(int id)
        //{
        //    return _context.SchoolModel.Any(e => e.Id == id);
        //}
    }
}
