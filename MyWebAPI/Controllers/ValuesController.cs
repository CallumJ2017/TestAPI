using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.BLL;

namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMyTestService _myTestService;

        public ValuesController(IMyTestService myTestService )
        {
            _myTestService = myTestService;
        }

        // GET api/values
        /// <summary>
        /// Get all values
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }


        /// <summary>
        /// Get value by Id
        /// </summary>
        // GET api/values/5 Find Action by ID
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return _myTestService.GetMyString();
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
