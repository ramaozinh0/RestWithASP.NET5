using RestWithASP.NET5.Model;
using RestWithASP.NET5.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;

namespace RestWithASP.NET5.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private MySqlContext _context;

        public PersonServiceImplementation(MySqlContext context) 
        {
            _context = context;
        }
        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            return person;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id == id);
            if (result != null) 
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        


        public Person FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id == id);
        }


        public Person Update(Person person)
        {

            if (!Exists(person.Id)) return new Person();

            var result = _context.Persons.SingleOrDefault(p => p.Id == person.Id);
            if(result != null) 
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            
            return person;
        }

        private bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id == id);
        }
    }
}
