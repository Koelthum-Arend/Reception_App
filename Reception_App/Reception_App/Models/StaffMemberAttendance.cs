using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reception_App.Models
{
    public class StaffMemberAttendance : IMeetingAttendance
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("StaffMember")]
        public int AttendeeID { get; set; }

        [ForeignKey("Meeting")]
        public Guid MeetingID { get; set; }


        public StaffMemberAttendance() 
        {

        }

        public StaffMemberAttendance(int staffID, Guid meetingID)
        {
            this.AttendeeID = staffID;
            this.MeetingID = meetingID;
        }
    }
}
