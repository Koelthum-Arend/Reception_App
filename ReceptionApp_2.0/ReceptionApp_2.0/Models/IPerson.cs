using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reception_App
{
   public interface IPerson
    {
        int ID { get; set; }
        string Name { get; set; }
        string Company { get; set; }
        string Role { get; set; }
        string Email { get; set; }
        string ContactNumber { get; set; }

        string ToString();

    }
}
