using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Itau.API.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        [Route("GetById")]
        public Customer Get(int id)
        {
            return new Customer().GetAll().FirstOrDefault(x => x.Id == id);
        }

        [HttpGet]
        [Route("GetByAll")]
        public IEnumerable<Customer> Get()
        {
            return new Customer().GetAll();
        }
    }
}
