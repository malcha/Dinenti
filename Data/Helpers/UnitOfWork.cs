using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Helpers
{
    public interface IUnitOfWork: IDisposable
    {
        DataContext GetDataContext();
    }

    public class UnitOfWork: IUnitOfWork
    {
        private DataContext _db;
        public UnitOfWork(DataContext db)
        {
            _db=db;
        }
        public DataContext GetDataContext(){
            return _db;
        }

        public void Dispose() 
        {
            _db.Dispose();
        }
    }
}
