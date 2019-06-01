using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController: ControllerBase
    {
        // GET api/customer
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"John Doe", "Will Smith"};
        }
    }
}