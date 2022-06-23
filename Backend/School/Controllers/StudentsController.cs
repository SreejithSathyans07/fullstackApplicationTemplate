using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Data;
using School.Models;
using System.Collections.Generic;
using System.Linq;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentsController(ApplicationDbContext DbContext)
        {
            _dbContext = DbContext;
        }
        [Route("")]
        public IActionResult Get()
        {
            IEnumerable<Student> Students = _dbContext.Students;
            return Ok(Students);
        }

        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var Students = from Student in _dbContext.Students where Student.Id == id select Student;
            return Ok(Students);
        }

        [HttpPost("")]
        public IActionResult AddStudent(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
