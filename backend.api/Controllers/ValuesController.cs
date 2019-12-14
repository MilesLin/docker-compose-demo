using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly NORTHWNDContext _db;

        public ValuesController(NORTHWNDContext db)
        {
            this._db = db;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<Customers> Get()
        {
            var customer = _db.Customers.First();
            return customer;
        }
    }
}
