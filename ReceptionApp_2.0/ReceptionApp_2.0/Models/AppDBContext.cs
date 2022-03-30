//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Reception_App.Models
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(Microsoft.EntityFrameworkCore.DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Staff> Staff { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<StaffAttendance> StaffMeetingAttendance { get; set; }
        public DbSet<VisitorAttendance> VisitorMeetingAttendance { get; set; }

        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Staff shakirah = new Staff(
                "Shakirah Brittle",
                    "WTC",
                     "Campus Coordinator",
                     "shakirah@wethinkcode.co.za",
                    "0000000000");
            shakirah.ID = 1;

            Staff awesome = new Staff(
                "Awesome Flan",
                    "WTC",
                   "Senior Developer",
                   "awesome@wethinkcode.co.za",
                    "1111111111"
                );
            awesome.ID = 2;

            Visitor potential = new Visitor(
                "Potential Investor",
                  "CoolTechStartup",
                 "CEO",
                "investor@cooltech.co.za",
                  "1234567890"
                );
            potential.ID = 1;

            Visitor prev = new Visitor(
                "Prev Student",
                     "CoolTechStartup",
                   "Junior developer",
                   "prev@cooltech.co.za",
                     "1112131415"
                );
            prev.ID = 2;

            DateTime dateTime1 = new DateTime(2022, 12, 1, 15, 30, 0);
            Meeting meeting1 = new Meeting("2022-12-01", "Investment");


            DateTime dateTime2 = new DateTime(2022, 12, 2, 16, 30, 0);
            Meeting meeting2 = new Meeting("2022-12-02", "Visit");

            modelBuilder.Entity<Staff>().HasData(
              shakirah,
              awesome,
                new Staff
                { 
                    ID = 3,
                    Name = "Ruin the Beer",
                    Company = "WTC",
                    Role = "Student Performance",
                    Email = "ruin@wethinkcode.co.za",
                    ContactNumber = "2222222222"
                },
                new Staff
                {
                    ID = 4,
                    Name = "Durian Woof",
                    Company = "WTC",
                    Role = "Senior Developer",
                    Email = "durian@wethinkcode.co.za",
                    ContactNumber = "3333333333"
                },
                new Staff
                {
                    ID = 5,
                    Name = "Ready Sett Go",
                    Company = "WTC",
                    Role = "Senior Developer",
                    Email = "ready@wethinkcode.co.za",
                    ContactNumber = "4444444444"
                }
           ); ;

            modelBuilder.Entity<Visitor>().HasData(
                potential,
                prev,

                new Visitor
                {
                    ID = 3,
                    Name = "Koel Thum",
                    Company = "CoolTechStartup",
                    Role = "Junior developer",
                    Email = "koel@cooltech.co.za",
                    ContactNumber = "1617181920"
                }
             );

            modelBuilder.Entity<Meeting>().HasData(
                meeting1,
                meeting2
             );

            modelBuilder.Entity<StaffAttendance>().HasData(
                new StaffAttendance
                {
                    ID = 1,
                    AttendeeID = shakirah.ID,
                    MeetingID = meeting1.MeetingID
                },

                new StaffAttendance
                {
                    ID = 2,
                    AttendeeID = awesome.ID,
                    MeetingID = meeting1.MeetingID
                },
                new StaffAttendance
                {
                    ID = 3,
                    AttendeeID = shakirah.ID,
                    MeetingID = meeting2.MeetingID
                }
             ); ;

            modelBuilder.Entity<VisitorAttendance>().HasData(
               new VisitorAttendance
               {
                   ID = 1,
                   AttendeeID = potential.ID,
                   MeetingID = meeting1.MeetingID
               },

               new VisitorAttendance
               {
                   ID = 2,
                   AttendeeID = prev.ID,
                   MeetingID = meeting2.MeetingID
               }
            );
        }
    }
}
