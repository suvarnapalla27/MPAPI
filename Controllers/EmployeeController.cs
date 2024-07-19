using APIProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        string cstring;
        private IConfiguration configuration;
        IEmployeeRepository employeeRepository;
        public EmployeeController(IConfiguration _configuration, IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
            configuration = _configuration;
            cstring = configuration.GetConnectionString("dbconn").ToString();
        }

        [HttpGet]
        public ActionResult GetEmployees()
        {
            List<Employee> employees = employeeRepository.GetEmployees(cstring);
            return Ok(employees);
        }


    }
}
