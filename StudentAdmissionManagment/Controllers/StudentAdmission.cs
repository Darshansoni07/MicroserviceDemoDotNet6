using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagment.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdmissionManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmission : ControllerBase
    {
        // GET: api/<StudentAdmission>
        [HttpGet("getData")]
        public IEnumerable<StudentAdmissionDetail> Get()
        {
            StudentAdmissionDetail admissionobj1 = new StudentAdmissionDetail();
            StudentAdmissionDetail admissionobj2 = new StudentAdmissionDetail();
            admissionobj1.StudentID = 1;
            admissionobj1.StudentName = "Adam";
            admissionobj1.StudentClass = "X";
            admissionobj2.StudentID = 2;
            admissionobj2.StudentName = "Brad";
            admissionobj2.StudentClass = "IX";
            List<StudentAdmissionDetail> listofobj = new List<StudentAdmissionDetail>
            {
                admissionobj1,
                admissionobj2
            };
            return listofobj;
        }

        // GET api/<StudentAdmission>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAdmission>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        
    }
}
