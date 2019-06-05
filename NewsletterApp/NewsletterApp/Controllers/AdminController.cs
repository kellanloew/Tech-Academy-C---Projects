using NewsletterApp.Models;
using NewsletterApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities()) //db is a new instance of db model in C# classes
            {
                var signups = (from c in db.Subscribers
                               where c.Removed == null
                               select c).ToList(); //LINQ statement to get list of non-removed subscribers
                var signupVms = new List<SignupVm>(); //New viewmodel signup instance
                foreach (var signup in signups) //Assigns data from db model to viewmodel instance
                {
                    var signupVm = new SignupVm();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVm.Id = signup.Id;
                    signupVms.Add(signupVm);
                }
                return View(signupVms);
            }
        }

        public ActionResult Unsubscribe(int id)
        {
            using(NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.Subscribers.Find(id); //Finds an entity based on primary key
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}