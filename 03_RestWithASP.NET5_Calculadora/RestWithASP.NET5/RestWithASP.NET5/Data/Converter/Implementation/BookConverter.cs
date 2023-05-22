using RestWithASP.NET5.Data.Converter.Contract;
using RestWithASP.NET5.Data.Converter.VO;
using RestWithASP.NET5.Data.VO;
using RestWithASP.NET5.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP.NET5.Data.Converter.Implementation
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origem)
        {
            if (origem == null) return null;
            return new Book
            {
                Id = origem.Id,
                Title = origem.Title,
                Author = origem.Author,
                Price = origem.Price,
                LaunchDate = origem.LaunchDate,
            };
        }

        public BookVO Parse(Book origem)
        {
            if (origem == null) return null;
            return new BookVO
            {
                Id = origem.Id,
                Title = origem.Title,
                Author = origem.Author,
                Price = origem.Price,
                LaunchDate = origem.LaunchDate,
            };
        }

        public List<Book> Parse(List<BookVO> origem)
        {
            if (origem == null) return null;
            return origem.Select(item => Parse(item)).ToList();
        }
        public List<BookVO> Parse(List<Book> origem)
        {
            if (origem == null) return null;
            return origem.Select(item => Parse(item)).ToList();
        }

    }
}
