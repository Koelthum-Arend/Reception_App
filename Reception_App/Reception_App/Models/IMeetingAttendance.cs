using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reception_App.Models
{
    interface IMeetingAttendance
    {
        int ID { get; set; }
        int AttendeeID { get; set; }
        Guid MeetingID { get; set; }

        string ToString();
    }
}
