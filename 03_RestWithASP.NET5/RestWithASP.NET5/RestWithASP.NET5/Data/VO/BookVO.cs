using System;
using RestWithASP.NET5.Hypermedia.Abstract;
using System.Collections.Generic;
using RestWithASP.NET5.Hypermedia;

namespace RestWithASP.NET5.Data.VO
{
    public class BookVO : ISupportHypermedia
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public DateTime LaunchDate { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
