using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication2.ViewModel
{
    public class ClientViewModel
    {
        public String Id { get; set; }
        [Required(ErrorMessage = "ErrorName")]
        [Display(Name = "Nombre")]
        public String Name { get; set; }
        [Display(Name = "Apellido")]
        [Required (ErrorMessage = "Error")]
        public String LastName { get; set; }
        [Required]
        public String Email { get; set; }
        public String Comment { get; set; }
    }
}