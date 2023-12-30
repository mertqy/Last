using System;
using System.Collections.Generic;

namespace Last.Models
{
    public interface IPersonRepository
    {
        Person GetPersonById(int id);
        IEnumerable<Person> GetAllPeople();
        Person Add(Person person);
        Person Update(Person personChanges);
        Person Delete(int id);
    }
}
