using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Commons.Entities
{
    public interface IEntity { }

}
namespace DTO
{

    public class Email : Commons.Entities.IEntity{

        public String Name { get; set; }
        public String EmailFrom { get; set; }
        public String Subject { get; set; }
        public String Message { get; set; }
    
    }
}