using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entities
{
    public class Admin
    {
        [DisplayName("Enter Username")]
        [Required(ErrorMessage ="Please enter Username")]
        public string Username { get; set; }

        [DisplayName("Enter Password")]
        [Required(ErrorMessage = "Please enter Username")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
