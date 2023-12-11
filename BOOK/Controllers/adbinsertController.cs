using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOOK.Models;

namespace BOOK.Controllers
{
    public class adbinsertController : Controller
    {

        DBMVCEntities dbobj = new DBMVCEntities();
        // GET: adbinsert
        public ActionResult ainsert_pageload()
        {
            return View();
        }
        public ActionResult ainsert_click(admininsert objcls)
        {

            dbobj.sp_ainsert(objcls.name, objcls.email, objcls.uname, objcls.password);
            objcls.msg = "successfully inserted";
            return View("ainsert_pageload",objcls);
        }
    }
}