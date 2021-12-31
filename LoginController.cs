using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    public class LoginController : Controller
    {
        projectEntities db = new projectEntities();
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(user u)
        {
            var user = db.users.Where(model => model.username == u.username && model.password == u.password).FirstOrDefault();
            if (user != null)
            {
                Session["UserId"] = u.id.ToString();
                Session["Username"] = u.username.ToString();
                TempData["LoginSuccessMessage"] = "<script>alert('Login sucessfully')</script>";

                return RedirectToAction("Create", "register1");
            }
            else
            {
                ViewBag.ErrorMessage = "<script>alert('User Name or Password is incorrect')</script>";
                return View();
            }

        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(user u)
        {
            if (ModelState.IsValid == true)
            {
                db.users.Add(u);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    ViewBag.InsertMessage = "<script>alert('registered sucessfully')</script>";
                    ModelState.Clear();

                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('registration failed')</script>";
                }
            }
            return View();
        }
	}
}