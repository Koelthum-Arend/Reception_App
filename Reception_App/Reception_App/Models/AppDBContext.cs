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

            StaffMember shakirah = new StaffMember(
                "Shakirah Brittle",
                    "WTC",
                     "Campus Coordinator",
                     "shakirah@wethinkcode.co.za",
                    "0000000000");

            StaffMember awesome = new StaffMember(
                "Awesome Flan",
                    "WTC",
                   "Senior Developer",
                   "awesome@wethinkcode.co.za",
                    "1111111111"
                );

            Visitor potential = new Visitor(
                "Potential Investor",
                  "CoolTechStartup",
                 "CEO",
                "investor@cooltech.co.za",
                  "1234567890"
                );

            Visitor prev = new Visitor(
                "Prev Student",
                     "CoolTechStartup",
                   "Junior developer",
                   "prev@cooltech.co.za",
                     "1112131415"
                );

            DateTime dateTime1 = new DateTime(2022, 12, 1, 15, 30,0);
            Meeting meeting1 = new Meeting(dateTime1, "Investment");

            DateTime dateTime2 = new DateTime(2022, 12, 2, 16, 30, 0);
            Meeting meeting2 = new Meeting(dateTime2, "Visit");

            modelBuilder.Entity<StaffMember>().HasData(
              shakirah,
              awesome,
                new StaffMember
                {
                    Name = "Ruin the Beer",
                    Company = "WTC",
                    Role = "Student Performance",
                    Email = "ruin@wethinkcode.co.za",
                    ContactNumber = "2222222222"
                },
                new StaffMember
                {
                    Name = "Durian Woof",
                    Company = "WTC",
                    Role = "Senior Developer",
                    Email = "durian@wethinkcode.co.za",
                    ContactNumber = "3333333333"
                },
                new StaffMember
                {
                    Name = "Ready Sett Go",
                    Company = "WTC",
                    Role = "Senior Developer",
                    Email = "ready@wethinkcode.co.za",
                    ContactNumber = "4444444444"
                }
           );

            modelBuilder.Entity<Visitor>().HasData(
                potential,
                prev,
                
                new Visitor
                {
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

            modelBuilder.Entity<StaffMemberAttendance>().HasData(
                new StaffMemberAttendance
                {
                    AttendeeID = shakirah.ID,
                    MeetingID = meeting1.MeetingID
                },

                new StaffMemberAttendance
                {
                    AttendeeID = awesome.ID,
                    MeetingID = meeting1.MeetingID
                },
                new StaffMemberAttendance
                {
                    AttendeeID = shakirah.ID,
                    MeetingID = meeting2.MeetingID
                }
             );

            modelBuilder.Entity<VisitorAttendance>().HasData(
               new VisitorAttendance
               {
                   AttendeeID = potential.ID,
                   MeetingID = meeting1.MeetingID
               },

               new VisitorAttendance
               {
                   AttendeeID = prev.ID,
                   MeetingID = meeting2.MeetingID
               }
            );
        }
    }

   
}
