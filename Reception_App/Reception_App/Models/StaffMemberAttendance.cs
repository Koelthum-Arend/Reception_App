﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reception_App.Models
{
    public class StaffMemberAttendance : IMeetingAttendance
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("StaffMember")]
        public int AttendeeID { get; set; }

        [ForeignKey("Meeting")]
        public Guid MeetingID { get; set; }
    }
}
