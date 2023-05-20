using RestWithASP.NET5.Model;
using System.Collections.Generic;

namespace RestWithASP.NET5.Repository
{
    public interface IPersonRepository
    {
        Person Create (Person person);
        Person FindById (long id);
        Person Update (Person person);
        List<Person> FindAll ();
        void Delete (long id);

        bool Exists(long id);
    }
}
