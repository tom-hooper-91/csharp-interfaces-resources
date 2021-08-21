using System;
using System.Collections.Generic;
using PersonReader.Interface;

namespace PersonReader.Service
{
    public class ServiceReader : IPersonReader
    {
        public IEnumerable<Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }
    }
}
