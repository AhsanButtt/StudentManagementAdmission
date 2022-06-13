using Microsoft.AspNetCore.Mvc;
using StudentManagementAdmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentManagementAdmission.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        // GET: api/<StudentAdmissionController>
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailsModel> Get()
        { 
        StudentAdmissionDetailsModel admissionobj1 = new StudentAdmissionDetailsModel();
        StudentAdmissionDetailsModel admissionobj2 = new StudentAdmissionDetailsModel();
        admissionobj1.StudentId = 1;
            admissionobj1.StudentName = "Adam";
            admissionobj1.StudentClass = "X";
            admissionobj1.DateOfJoining = DateTime.Now;
            admissionobj2.StudentId = 2;
            admissionobj2.StudentName = "Brad";
            admissionobj2.StudentClass = "IX";
            admissionobj2.DateOfJoining = DateTime.Now;
            List<StudentAdmissionDetailsModel> listofobj = new List<StudentAdmissionDetailsModel>
            {
                admissionobj1,
                admissionobj2
            };
            return listofobj;
        }

    //// GET api/<StudentAdmissionController>/5
    //[HttpGet("{id}")]
    //    public string Get(int id)
    //    {
    //        return "value";
    //    }

    //    // POST api/<StudentAdmissionController>
    //    [HttpPost]
    //    public void Post([FromBody] string value)
    //    {
    //    }

    //    // PUT api/<StudentAdmissionController>/5
    //    [HttpPut("{id}")]
    //    public void Put(int id, [FromBody] string value)
    //    {
    //    }

    //    // DELETE api/<StudentAdmissionController>/5
    //    [HttpDelete("{id}")]
    //    public void Delete(int id)
    //    {
    //    }
    }
}
