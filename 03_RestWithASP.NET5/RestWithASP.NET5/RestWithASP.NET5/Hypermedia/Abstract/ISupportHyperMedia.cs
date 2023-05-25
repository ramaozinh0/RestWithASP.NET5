using System.Collections.Generic;

namespace RestWithASP.NET5.Hypermedia.Abstract
{
    public interface ISupportHypermedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
