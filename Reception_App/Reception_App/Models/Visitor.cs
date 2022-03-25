using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reception_App.Models
{
    public class Visitor : IPerson
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Company is required")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contact cannot be longer than 10 digits"), StringLength(10)]
        public string ContactNumber { get; set; }

        public Visitor()
        {

        }

        public Visitor(string Name, string Company, string Role, string Email, string ContactNumber) {
            this.Name = Name;
            this.Company = Company;
            this.Role = Role;
            this.Email = Email;
            this.ContactNumber = ContactNumber;
        }

        public override string ToString()
        {
            return $"ID: {this.ID}\nName: {this.Name}\nCompany: {this.Company}\nRole: {this.Role}\nEmail: {this.Email}\nContactNumber: {this.ContactNumber}";
        }
    }
}
