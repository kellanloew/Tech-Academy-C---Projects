using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller //Controller comes is defined in a namespace in System.Web.Mvc
    {                                        //"Home" means this must be entered in the url to call this controller class
        public ActionResult Index() //ActionResult is defined in the System.Web.Mvc library. Returns some action.
                                    //Here, it returns the View() action
        {
            return View(); //View is a method defined in the Controller class
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Instructor(int id) //The int id is passed into this method by the URL
        {
            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };
            //ViewBag.id = id;
            return View(dayTimeInstructor);
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Dan",
                    LastName = "Christie"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Cole",
                    LastName = "Dixon"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Adam",
                    LastName = "Smithsonian"
                }
            };
            return View(instructors);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - The Tech Academy";

            return View();
        }
    }
}