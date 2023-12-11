using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BOOK.Models
{
    public class login
    {
        [Required(ErrorMessage ="enter the username")]
        public string uname { get; set; }
        [Required(ErrorMessage ="enter the password")]
        public string password { get; set; }
        public string msg { set; get; }
    }
}