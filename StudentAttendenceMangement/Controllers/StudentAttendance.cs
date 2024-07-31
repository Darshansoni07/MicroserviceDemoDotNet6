using Microsoft.AspNetCore.Mvc;
using StudentAttendenceMangement.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendenceMangement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendance : ControllerBase
    {
        // GET: api/<StudentAttendance>
        [HttpGet("getData")]
        public IEnumerable<StudentAttendanceDetails> Get()
        {
            StudentAttendanceDetails attendanceObj1 = new StudentAttendanceDetails();
            StudentAttendanceDetails attendanceObj2 = new StudentAttendanceDetails();
            attendanceObj1.StudentID = 1;
            attendanceObj1.StudentName = "Adam";
            attendanceObj1.AttendencePercentage = 83.02;
            attendanceObj2.StudentID = 2;
            attendanceObj2.StudentName = "Brad";
            attendanceObj2.AttendencePercentage = 71.02;
            List<StudentAttendanceDetails> listObj = new List<StudentAttendanceDetails>
            {
                attendanceObj1,
                attendanceObj2
            };
            return listObj;
        }

        // GET api/<StudentAttendance>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAttendance>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
