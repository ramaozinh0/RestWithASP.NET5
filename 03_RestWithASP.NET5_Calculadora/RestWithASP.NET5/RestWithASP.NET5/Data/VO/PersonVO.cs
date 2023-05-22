using RestWithASP.NET5.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASP.NET5.Data.Converter.VO
{

    public class PersonVO
    {

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

    }
}
