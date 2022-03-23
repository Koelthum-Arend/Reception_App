using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reception_App.Models
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }

        public Person(string Name, string Company, string Role, string Email, string ContactNumber) {
            this.Name = Name;
            this.Company = Company;
            this.Role = Role;
            this.Email = Email;
            this.ContactNumber = ContactNumber;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}\nCompany: {this.Company}\nRole: {this.Role}\nEmail: {this.Email}\nContactNumber: {this.ContactNumber}";
        }
    }
}
