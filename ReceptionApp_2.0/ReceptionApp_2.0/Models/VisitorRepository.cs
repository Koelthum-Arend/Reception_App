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

        public Visitor CreateVisitor(Visitor visitor)
        {
            _context.Visitors.Add(visitor);
            _context.SaveChanges();
            return visitor;
        }

        public Visitor ReadVisitor(int id)
        {
           return _context.Visitors.Find(id);

        }

        public IEnumerable<Visitor> ReadVisitors()
        {
            return _context.Visitors;
        }

        public Visitor UpdateVisitor(Visitor visitorChanges)
        {
            var visitor = _context.Visitors.Attach(visitorChanges);
            visitor.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return visitorChanges;
        }

        public Visitor DeleteVisitor(int id)
        {
            var visitor = _context.Visitors.Find(id);

            if (visitor != null)
            {
                _context.Visitors.Remove(visitor);
                _context.SaveChanges();
            }
            return visitor;
        }
    }
}
