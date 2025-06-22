using API_ITI_1.Models;
using API_ITI_1.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace API_ITI_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        public IRepository<Courses> Courses { get; }

        public CoursesController(IRepository<Courses> Courses)
        {
            this.Courses = Courses;
        }

        //
        [HttpGet("/api/AllCourses")]
        public ActionResult GetAllCorses()
        {
           var data = Courses.View();
            if (data.Count == 0)
            {
                return NotFound("No courses found");
            }
            return Ok(data);

        }
        //
        [HttpGet("/api/GetById/{Id}")]
        public ActionResult GetById(int Id)
        {
            var data = Courses.FindById(Id);
            if (data == null)
            {
                return NotFound("Course not found");
            }
            return Ok(data);
        }
        //
        [HttpGet("/api/GetByName/{Name}")]
        public ActionResult GetByName(string Name)
        {
            var data = Courses.FindByName(Name);   
            if (data == null)
            {
                return NotFound("Course not found");
            }
            return Ok(data);
        }
        //
        [HttpPost("/api/AddCourse")]
        public ActionResult AddCourse(Courses Course)
        {
          if(Course == null)    return BadRequest("Course data is null");
          Courses.Add(Course);
            return Created();
        }
        //
        [HttpDelete("/api/deleteCourse/{Id}")]
        public ActionResult DeleteCourse( int Id)
        {
            var data = Courses.FindById(Id);
            if (data == null)
            {
                return NotFound("Course not found");
            }
            Courses.Delete(Id, data);
            var allCourses = Courses.View();        
            return Ok(allCourses);

        }
        //
        [HttpPut("/api/UpdateCourse/{Id,Course}")]
        public ActionResult UpdateCourse(int Id, Courses Course )
        {
            var data = Courses.FindById(Id);
            if (data == null)
                return NotFound("Course not found");
            if (data.Id!= Course.Id)
            return BadRequest();
            Courses.Update(Id, Course);
            return NoContent();
        }
    }
}
