using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOOK.Models;

namespace BOOK.Controllers
{
    public class loginController : Controller
    {
        DBMVCEntities dbobj = new DBMVCEntities();
        

        // GET: login
        public ActionResult login_pageload()
        {
            return View();
        }
        public ActionResult login_click(login objcls)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_login(objcls.uname, objcls.password, op);
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    Session["uname"] = objcls.uname;
                    return RedirectToAction("Home");
                }
                else
                {
                    ModelState.Clear();
                    objcls.msg = "invalid username or password";
                    return View("login_pageload", objcls);
                }
               
            }
            return View("login_pageload",objcls);
        }
        public ActionResult home()
        {
            return View();
        }
    }
}