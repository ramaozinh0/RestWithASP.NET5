using RestWithASP.NET5.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Threading;

namespace RestWithASP.NET5.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i)
                persons.Add(person) ;
            }
            return persons;
        }

        

        private long IncrementAndget()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndget,
                FirstName = "Test",
                LastName = "Test",
                Address = "Uberlandia MG",
                Gender = "Male"
            };
        }

        private Person MockPerson(int i)
        {
            {
                Id = IncrementAndget(),
                FirstName = "Person Name",
                LastName = "Person LastName",
                Address = "Some Address",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
