using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reception_App.Models
{
    public class VisitorRepository
    {
        private readonly AppDBContext _context;

        //dependency injection
        public VisitorRepository(AppDBContext context)
        {
            this._context = context;
        }

        public Visitor Add(Visitor visitor) 
        {
            _context.Visitors.Add(visitor);
            _context.SaveChanges();
            return visitor;
        }

        public Visitor Delete(int id)
        {
            Visitor visitor = _context.Visitors.Find(id);

            if (visitor != null)
            {
                _context.Visitors.Remove(visitor);
                _context.SaveChanges();
            }

            else
            {
                Console.WriteLine("Visitor does not exist");
            }
            return visitor;
        }

        public IEnumerable<Visitor> GetAllVisitors()
        {
           return _context.Visitors;
        }

        public Visitor GetVisitor(int id)
        {
            return _context.Visitors.Find(id);
        }

        public Visitor Update(Visitor visitorChanges)
        {
            var visitor = _context.Visitors.Attach(visitorChanges);
            visitor.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return visitorChanges;
        }
    }
}
