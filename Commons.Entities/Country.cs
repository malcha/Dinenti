using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commons.Entities
{
    public class Country
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string IsoCode { get; set; }
    }
}
