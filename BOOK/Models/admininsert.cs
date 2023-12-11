using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BOOK.Models
{
    public class admininsert
    {
        [Required(ErrorMessage ="enter the name")]
        public string name { get; set; }
        [EmailAddress(ErrorMessage ="enter the valid address")]
        public string email { get; set; }
        public string uname { get; set; }
        public string password { get; set; }
        [Compare("password",ErrorMessage ="password mismatch")]

        public string confirmpassword { get; set; }

        public string msg { get; set; }
    }
}