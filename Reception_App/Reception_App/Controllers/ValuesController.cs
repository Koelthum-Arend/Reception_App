using Microsoft.AspNetCore.Mvc;
using Reception_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reception_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly VisitorRepository _repo;

        public ValuesController(VisitorRepository repo)
        {
            this._repo = repo;
        }
        // GET: api/<ValuesController>
        [HttpGet("visitors")]
        public IEnumerable<Visitor> Get()
        {
            var visitors = _repo.GetAllVisitors();
            Console.WriteLine(from vistor in visitors select vistor);

            return visitors;
            //return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
