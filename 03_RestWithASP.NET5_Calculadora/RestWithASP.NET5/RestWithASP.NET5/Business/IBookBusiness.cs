using RestWithASP.NET5.Data.VO;
using RestWithASP.NET5.Model;
using System.Collections.Generic;

namespace RestWithASP.NET5.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}
