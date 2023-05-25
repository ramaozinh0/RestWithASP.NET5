using RestWithASP.NET5.Hypermedia;
using RestWithASP.NET5.Hypermedia.Abstract;
using RestWithASP.NET5.Model.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASP.NET5.Data.Converter.VO
{

    public class PersonVO : ISupportHypermedia
    {

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
