using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication2.Models;
using MvcApplication2.DataLoad;

namespace MvcApplication2.Manager
{
    public class ClouthManager
    {

        public IEnumerable<Clouth> FindAll()
        {
            return ClouthDataLoader.Data();
        }




    }
}