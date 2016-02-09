using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Entities
{
    public class Clouth
    {

        public int Id { get; set; }
        public string Description { get; set; }

        public string Size { get; set; }

        public string Colours { get; set; }

        public decimal Price { get; set; }

        public bool Active { get; set; }
    }
}
