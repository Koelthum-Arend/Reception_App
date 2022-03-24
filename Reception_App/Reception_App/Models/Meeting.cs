using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reception_App.Models
{
    public class Meeting
    {
        [Key]
        Guid MeetingID { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        DateTime Date { get; set; }

        [Required(ErrorMessage = "Time is required")]
        [DataType(DataType.Time)]
        DateTime Time { get; set; }

        public Meeting(DateTime date, DateTime time) {
            this.MeetingID = Guid.NewGuid();
            this.Date = date;
            this.Time = time;
         }


    }


}
