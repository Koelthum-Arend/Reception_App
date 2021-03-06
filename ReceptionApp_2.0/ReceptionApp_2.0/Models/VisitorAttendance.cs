using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reception_App.Models
{
    public class VisitorAttendance : IMeetingAttendance
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Visitor")]
        public int AttendeeID { get; set; }

        [ForeignKey("Meeting")]
        public Guid MeetingID { get; set; }

        public VisitorAttendance()
        {

        }

        public VisitorAttendance(int visitorID, Guid meetingID)
        {
            this.AttendeeID = visitorID;
            this.MeetingID = meetingID;
        }

    }
}