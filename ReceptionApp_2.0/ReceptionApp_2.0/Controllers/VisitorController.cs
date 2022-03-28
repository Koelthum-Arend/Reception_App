using Microsoft.AspNetCore.Mvc;
using Reception_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReceptionApp_2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly VisitorRepository _context;
        public VisitorController(VisitorRepository repo)
        {
            _context = repo;
        }
        // GET: api/<VisitorController>
        [HttpGet]
        public IEnumerable<Visitor> GetVisitors()
        {
            return _context.ReadVisitors();
        }

        // GET api/<VisitorController>/5
        [HttpGet("{id}")]
        public Visitor GetVisitor(int id)
        {
            return _context.ReadVisitor(id);
        }

        // POST api/<VisitorController>
        [HttpPost]
        public void PostVisitor(Staff visitor)
        {
            _context.Add(visitor);
        }

        // PUT api/<VisitorController>/5
        [HttpPut]
        public void Put(Staff visitorChanges)
        {
            _context.Update(visitorChanges);
        }

        // DELETE api/<VisitorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Delete(id);
        }
    }
}
