using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reception_App.Models
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public  DbSet<StaffMember> Staff { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<StaffMemberAttendance> StaffMeetingAttendance { get; set; }
        public DbSet<VisitorAttendance> VisitorMeetingAttendance { get; set; }

        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffMember>().HasData(

                new StaffMember
                {
                Name = "Koel",
                Company = "Company",
                Role = "Role",
                Email = "Email",
                ContactNumber = "0849779380"
        }
              );
        }
    }

   
}
