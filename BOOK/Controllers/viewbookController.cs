using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOOK.Models;

namespace BOOK.Controllers
{
    public class viewbookController : Controller
    {
        DBMVCEntities dbobj = new DBMVCEntities();
            
        // GET: viewbook
        public ActionResult book_pageload(book ob)
        {

            
            return View(dbobj.books.ToList());
        }
    }
}