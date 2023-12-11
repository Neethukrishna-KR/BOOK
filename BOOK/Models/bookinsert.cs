using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BOOK.Models
{
    public class bookinsert
    {
        [Required(ErrorMessage ="enter the name")]
        public string name { get; set; }
        [Required(ErrorMessage ="enter the price")]
        public int price { get; set; }
        [Required(ErrorMessage ="enter the author name")]
        public string author { get; set; }
        
        public string image { get; set; }

        public string msg { set; get; }
    }
}