using EmployeeApplication.Model.Models;
using EmployeeApplication.Repository.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {

        private readonly EmployeeApplicationContext? _context;

        public LocationController(EmployeeApplicationContext DbCon)
        {
            this._context = DbCon;
        }



        [HttpPost("Addlocation")]
        public void Addlocation (string Name)
        {
            Location location = new Location();
            location.Name = Name;
            _context?.Add(location);
            _context?.SaveChanges();

        }

        [HttpDelete("deleteById")]

        public void Deletebyid(int id)
        {
            Location location = new Location();
            location.Id = id;
            _context?.Remove(location);
            _context?.SaveChanges();
        }


        [HttpGet("Getalldata")]

        public IActionResult Getallelements() 
        {
            Location location = new Location();
            
            return Ok(_context?.locations);
        }

        [HttpGet("GetdatabyId")]

        public IActionResult Getelementbyid(int id)
        {
            Location location = _context.locations.FirstOrDefault(ele => ele.Id == id);
            
            
            return Ok(location);
        }

        [HttpPut("Updatetable")]

        public void Updatetable(int id, string name)
        {
            Location location = new Location();
            var x = _context?.locations.Find(id);
            x.Name = name;
            _context?.SaveChanges();

        }




    }
}