using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication19.Models;
using WebApplication19.ViewModel;

namespace WebApplication19.Controllers
{
    public class viewController : Controller
    {
        //
        // GET: /view/
        public ActionResult Index()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "login");
            }
            else
            {
                return View();
            }

        }
        public ActionResult show()
        {
            projectEntities db = new projectEntities();
            List<user> users = db.users.ToList();
  
            return View(users);
        }
        public ActionResult orders()
        {
            projectEntities db1 = new projectEntities();
            List<register> registers = db1.registers.ToList();

            return View(registers);
        }
        public ActionResult multidata()
        {
            projectEntities db = new projectEntities();
            projectEntities db1 = new projectEntities();
            

           var mymodel= new  multipleData();
           mymodel.users = db.users.ToList();
           mymodel.registers = db1.registers.ToList();
           return View(mymodel);
          
		  


          
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("admin", "admin");
        }

	}
}