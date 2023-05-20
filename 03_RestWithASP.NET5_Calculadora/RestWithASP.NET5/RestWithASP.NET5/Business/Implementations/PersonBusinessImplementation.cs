using RestWithASP.NET5.Model;
using RestWithASP.NET5.Model.Context;
using RestWithASP.NET5.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;

namespace RestWithASP.NET5.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository) 
        {
            _repository = repository;
        }
        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        


        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }


        public Person Update(Person person)
        {

            return _repository.Update(person);
        }

    }
}
