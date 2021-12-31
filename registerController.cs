using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    public class registerController : Controller
    {
        projectEntities db = new projectEntities();
        //
        // GET: /register/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult register(register u)
        {
            if (ModelState.IsValid == true)
            {
                db.registers.Add(u);
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