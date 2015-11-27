using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Providers.DTO
{
    public class Recommendation
    {
        public IEnumerable<string> data { get; set; }

        public Metadata metadata{get; set;}

        
    }

    public class Metadata{
        public string recommendation_id {get; set;}
    }
}