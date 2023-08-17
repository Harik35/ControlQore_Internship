using EmployeeApplication.Model.Models;
using EmployeeApplication.Repository.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApplication2.Controllers
{
    public class EmployeeController: ControllerBase
    {
        private readonly EmployeeApplicationContext? _context;

        public EmployeeController(EmployeeApplicationContext DbCon)
        {
            this._context = DbCon;
        }



        [HttpPost("AddEmployee")]
        public void AddEmployee(EmployeeDuplicate employee)
        {

            Employee emp = new Employee();
            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.Email = employee.Email;
            emp.PhoneNumber = employee.PhoneNumber;
            emp.DepartmentId = employee.DepartmentId;
            _context?.Add(emp);
            _context?.SaveChanges();

        }

        [HttpDelete("deleteById")]

        public void Deletebyid(int id)
        {
            Employee emp = new Employee();
            emp.Id = id;
            _context?.Remove(emp);
            _context?.SaveChanges();
        }


        [HttpGet("Getalldata")]

        public IActionResult Getallelements()
        {


            return Ok(_context?.employees);
        }

        [HttpGet("GetdatabyId")]

        public IActionResult Getelementbyid(int id)
        {
            Employee emp = _context.employees.FirstOrDefault(ele => ele.Id == id);


            return Ok(emp);
        }

        [HttpPut("Updatetable")]

        public void Updatetable(int id, EmployeeDuplicate emp)
        {
            var employ = _context?.employees.Find(id);
            employ.FirstName = emp.FirstName;
            employ.LastName = emp.LastName;
            employ.Email = emp.Email;
            employ.PhoneNumber = emp.PhoneNumber;
            employ.DepartmentId = emp.DepartmentId;
            _context?.SaveChanges();
        }
    }
}
