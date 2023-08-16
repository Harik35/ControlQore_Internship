using EmployeeApplication.Model.Models;
using EmployeeApplication.Repository.Context;
using Microsoft.AspNetCore.Mvc;

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
    }
}