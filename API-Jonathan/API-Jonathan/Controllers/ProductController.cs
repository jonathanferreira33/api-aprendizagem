using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Jonathan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("GetById")]
        public Customer Get(int id)
        {
            return new Product().GetAll().FirstOrDefault(x => x.id == id);
        }

        [HttpGet]
        [Route("GetByAll")]
        public IEnumerable<Customer> Get()
        {
            return new Product().GetAll();
        }

        [HttpDelete]
        [Route("Delete")]
        public Customer Delete(int id)
        {
            return new Product().GetAll().FirstOrDefault(x => x.id == id);
        }

        [HttpPut]
        [Route("Put")]


    }
}
