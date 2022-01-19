using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Itau.API.Controllers.v1
{
    [ApiController]
    [Route("employee")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("GetById")]
        public Employee Get(int id)
        {
            return new Employee().GetAll().FirstOrDefault(x => x.Id == id);
        }

        [HttpGet]
        [Route("GetByAll")]
        public IEnumerable<Employee> Get()
        {
            return new Employee().GetAll();
        }
    }
}
