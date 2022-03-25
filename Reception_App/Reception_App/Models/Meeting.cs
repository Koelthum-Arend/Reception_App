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
        public string Date { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public Meeting()
        {

        }
        public Meeting(string date, string descsription) {
            this.MeetingID = Guid.NewGuid();
            this.Date = date;
            this.Description = descsription;
         }


    }


}
