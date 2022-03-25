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
        public Guid MeetingID { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.DateTime)]
        DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [DataType(DataType.Text)]
        string Description { get; set; }

        public Meeting(DateTime date, string descsription) {
            this.MeetingID = Guid.NewGuid();
            this.DateTime = date;
            this.Description = descsription;
         }


    }


}
