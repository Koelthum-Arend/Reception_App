using Reception_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptionApp_2._0.Models
{
    public class StaffRepository
    {
        private readonly AppDBContext _context;

        public StaffRepository(AppDBContext context)
        {
            this._context = context;
        }

        public Staff CreateStaffMember(Staff member)
        {
            _context.Staff.Add(member);
            _context.SaveChanges();
            return member;
        }

        public IEnumerable<Staff> ReadAllStaff()
        {
            return _context.Staff;
        }

        public Staff ReadStaffMember(int id)
        {
            return _context.Staff.Find(id);
        }

        public Staff UpdateStaffMember(Staff memberChanges)
        {
            var member = _context.Staff.Attach(memberChanges);
            member.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return memberChanges;
        }

        public Staff DeleteStaffMember(int id)
        {
            Staff member = _context.Staff.Find(id);

            if (member != null)
            {
                _context.Staff.Remove(member);
                _context.SaveChanges();
            }

            else
            {
                Console.WriteLine("Visitor does not exist");
            }
            return member;
        }
    }
}

