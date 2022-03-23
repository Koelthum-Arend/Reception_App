using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reception_App
{
    interface IPerson
    {
        string Name { get; set; }
        string Company { get; set; }
        string Role { get; set; }
        string Email { get; set; }
        string ContactNumber { get; set; }

    }
}
