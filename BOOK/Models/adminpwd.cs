using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BOOK.Models
{
    public class adminpwd
    {
        public string oldpassword { set; get; }
        [Required(ErrorMessage ="enter the password")]

        public string newpassword { set; get; }
        [Compare("newpassword",ErrorMessage ="password mismatch")]
        public string confirmpassword { set; get; }

        public string msg { set; get; }
    }
}