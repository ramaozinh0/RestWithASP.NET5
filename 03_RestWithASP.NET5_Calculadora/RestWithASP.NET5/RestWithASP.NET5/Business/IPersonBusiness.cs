using RestWithASP.NET5.Data.Converter.VO;
using System.Collections.Generic;

namespace RestWithASP.NET5.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create (PersonVO person);
        PersonVO FindById (long id);
        PersonVO Update (PersonVO person);
        List<PersonVO> FindAll ();
        void Delete (long id);
    }
}
