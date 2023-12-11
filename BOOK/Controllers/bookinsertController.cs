
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOOK.Models;
using System.IO;

namespace BOOK.Controllers
{
    public class bookinsertController : Controller
    {
        DBMVCEntities dbobj = new DBMVCEntities();
        // GET: bookinsert
        public ActionResult binsert_pageload()
        {
            return View();
        }
        public ActionResult binsert_click(bookinsert objcls,HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/phs");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);
                    var fullpath = Path.Combine("~\\phs", fname);
                    objcls.image = fullpath;

                    dbobj.sp_binsert(objcls.name, objcls.price, objcls.author, objcls.image);
                    objcls.msg = "successfully inserted";
                    return View("binsert_pageload", objcls);

                    
                }
            }

            return View("binsert_pageload",objcls);
        }
    }
}