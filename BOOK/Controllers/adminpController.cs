using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOOK.Models;

namespace BOOK.Controllers
{
    public class adminpController : Controller
    {
        DBMVCEntities dbobj = new DBMVCEntities();
        // GET: adminp
        public ActionResult profile_pageload()
        {
            var getdata = dbobj.sp_aprofile(Session["uname"].ToString()).FirstOrDefault();

            return View(new adminp

            {
                name=getdata.name,
                email=getdata.email

            }
                
                
                
                );
        }
        public ActionResult pa_update(adminp obj)
        {
            dbobj.sp_apupdate(Session["uname"].ToString(), obj.name, obj.email);
            var getdata = dbobj.sp_aprofile(Session["uname"].ToString()).FirstOrDefault();
            return View("profile_pageload", new adminp
            {
                name = getdata.name,//set

                

                email = getdata.email
               


            }
            );
        }


    }
}