using Microsoft.AspNetCore.Mvc;
using WebApplication_Enity_Framework_10_08_2023.Models;


namespace WebApplication_Enity_Framework_10_08_2023.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentDetails : ControllerBase
    {
        [HttpPost("InsertStudent")]

        public IActionResult AddData(string name, int age, float Mark, string deptstring)
        {
            DbFile query = new DbFile();
            Student student = new Student();
            student.Name = name;
            student.Age = age;
            student.Mark = Mark;
            student.Dep = deptstring;
            query.StudentDataUsingSP(student);
            return Ok();
        }

       

    }
}