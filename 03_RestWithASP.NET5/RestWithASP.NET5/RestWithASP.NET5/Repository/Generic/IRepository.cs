using RestWithASP.NET5.Model;
using RestWithASP.NET5.Model.Base;
using System.Collections.Generic;

namespace RestWithASP.NET5.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create (T item);
        T FindById (long id);
        T Update (T item);
        List<T> FindAll ();
        void Delete (long id);

        bool Exists(long id);
    }
}
