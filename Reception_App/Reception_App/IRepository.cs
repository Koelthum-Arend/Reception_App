using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reception_App
{
    public interface IRepository
    {
        IPerson GetAllPeople();
        IEnumerable<IPerson> GetPerson(int Id);
        IPerson AddPerson(IPerson person);
        IPerson UpdatePerson(IPerson personChanges);
        IPerson DeletePerson(int Id);

    }
}
