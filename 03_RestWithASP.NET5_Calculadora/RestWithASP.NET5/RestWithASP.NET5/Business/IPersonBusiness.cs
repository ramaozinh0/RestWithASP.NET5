﻿using RestWithASP.NET5.Model;
using System.Collections.Generic;

namespace RestWithASP.NET5.Business
{
    public interface IPersonBusiness
    {
        Person Create (Person person);
        Person FindById (long id);
        Person Update (Person person);
        List<Person> FindAll ();
        void Delete (long id);
    }
}