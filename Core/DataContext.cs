using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DataContext: Data.DataContext
    {
        public DataContext(DbConnection connection)
            :base(connection){}

        public DataContext(){ }

        //Todo error
        //protected override Exception GetEntityValidationException(DbEntityValidationException ex)
        //{
        //    return new Exceptions.EntityValidationException(ex.EntityValidationErrors);
        //}
    }
}
