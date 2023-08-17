using EmployeeApplication.Model.Models;
using EmployeeApplication.Repository.Context;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]

    
    public class DepartmentController: ControllerBase
    {
        private readonly EmployeeApplicationContext? _context;

        public DepartmentController(EmployeeApplicationContext DbCon)
        {
            this._context = DbCon;
        }



        [HttpPost("AddDepartment")]
        public void AddDepartment(DepartmentDuplicate dept)
        {
          
            Department dep = new Department();   
            dep.Name = dept.Name;
            dep.LocationId = dept.LocationId;
            _context?.Add(dep);
            _context?.SaveChanges();

        }

        [HttpDelete("deleteById")]

        public void Deletebyid(int id)
        {
            Department dep = new Department();
            dep.Id = id;
            _context?.Remove(dep);
            _context?.SaveChanges();
        }


        [HttpGet("Getalldata")]

        public IActionResult Getallelements()
        {
            

            return Ok(_context?.department);
        }

        [HttpGet("GetdatabyId")]

        public IActionResult Getelementbyid(int id)
        {
            Department dep = _context.department.FirstOrDefault(ele => ele.Id == id);


            return Ok(dep);
        }


        [HttpPut("Updatetable")]

        public void Updatetable(int id, DepartmentDuplicate dept)
        {
            
            var dep = _context?.department.Find(id);
            dep.Name = dept.Name;
            dep.LocationId = dept.LocationId;
            _context?.SaveChanges();

        }
    }
}
