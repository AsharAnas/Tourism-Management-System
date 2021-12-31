using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    public class adminController : Controller
    {
        //
        // GET: /admin/

        projectEntities db = new projectEntities();
        //
        // GET: /admin/
        public ActionResult Index()
        {
            return View();

        }


        public ActionResult admin()
        {
         
                return View();
            


        }
        [HttpPost]
        public ActionResult admin(admin a)
        {
            var admin = db.admins.Where(model => model.name == a.name && model.password == a.password).FirstOrDefault();
            if (admin != null)
            {
                Session["UserId"] = a.id.ToString();
                Session["Username"] = a.name.ToString();
                TempData["LoginSuccessMessage"] = "<script>alert('Login sucessfully')</script>";

                return RedirectToAction("show", "view");
                
            }
            else
            {
                ViewBag.ErrorMessage = "<script>alert('User Name or Password is incorrect')</script>";
                return View();
            }

          

        }
	}
}