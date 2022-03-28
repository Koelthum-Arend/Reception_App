using Reception_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptionApp_2._0.Models
{
    public class MeetingAttendanceRepository
    {
        private readonly AppDBContext _context;

        public MeetingAttendanceRepository(AppDBContext context)
        {
            _context = context;
        }

        public VisitorAttendance AddVisitor(VisitorAttendance attendance)
        {
            _context.VisitorMeetingAttendance.Add(attendance);
            _context.SaveChanges();
            return attendance;
        }

        public VisitorAttendance DeleteVisitor(int id)
        {
            VisitorAttendance visitor = _context.VisitorMeetingAttendance.Find(id);

            if (visitor != null)
            {
                _context.VisitorMeetingAttendance.Remove(visitor);
                _context.SaveChanges();
            }

            else
            {
                Console.WriteLine("Visitor does not exist");
            }
            return visitor;
        }

        public VisitorAttendance UpdateVistor(VisitorAttendance attendanceChanges)
        {
            var visitor = _context.VisitorMeetingAttendance.Attach(attendanceChanges);
            visitor.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return attendanceChanges;
        }

        public IEnumerable<VisitorAttendance> GetVisitorAttendances()
        {
            return _context.VisitorMeetingAttendance;
        }

        public VisitorAttendance GetVisitorAttendance(int id)
        {
            return _context.VisitorMeetingAttendance.Find(id);
        }

        public StaffAttendance AddStaff(StaffAttendance attendance)
        {
            _context.StaffMeetingAttendance.Add(attendance);
            _context.SaveChanges();
            return attendance;
        }

        public StaffAttendance DeleteStaff(int id)
        {
            StaffAttendance staff = _context.StaffMeetingAttendance.Find(id);

            if (staff != null)
            {
                _context.StaffMeetingAttendance.Remove(staff);
                _context.SaveChanges();
            }

            else
            {
                Console.WriteLine("Staff Member does not exist");
            }
            return staff;
        }

        public StaffAttendance UpdateStaff(StaffAttendance attendanceChanges)
        {
            var staff = _context.StaffMeetingAttendance.Attach(attendanceChanges);
            staff.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return attendanceChanges;
        }

        public IEnumerable<StaffAttendance> GetStaffAttendances()
        {
            return _context.StaffMeetingAttendance;
        }

        public StaffAttendance GetStaffAttendance(int id)
        {
            return _context.StaffMeetingAttendance.Find(id);
        }
    }
}
