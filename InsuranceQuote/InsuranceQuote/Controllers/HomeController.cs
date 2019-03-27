using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InsuranceQuote.Models;
using InsuranceQuote.ViewModels;


namespace InsuranceQuote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(string firstName, string lastName, string emailAddress,
            DateTime DOB, string make, string model, int year, bool DUI, int tickets,
            string liability, string fullCoverage)
        {
            //Calculate quote

            const int basePrice = 50;
            int quote = basePrice;
            int age;
            int fullCover = 0;
            decimal finalQuote; //decimal for exact calculations and maps to the datatype of money in DB

            if (DOB.Month - DateTime.Now.Month <= 0)
            {
                age = DateTime.Now.Year - DOB.Year;
            }
            else age = DateTime.Now.Year - DOB.Year - 1;

            if (age < 18) quote += 100;
            else if (age < 25) quote += 25;
            else if (age > 100) quote += 25;

            if (year < 2000 || year > 2015) quote += 25;

            make = make.ToLower();
            model = model.ToLower();
            if (make == "porsche") quote += 25;
            if (make == "porsche" && model == "911 Carrera") quote += 25;

            for(int i = 0; i < tickets; i++) quote += 10;

            finalQuote = quote;
            if (DUI == true) finalQuote += .25m * finalQuote;

            if (fullCoverage == "FullCoverage")
            {
                finalQuote += .5m * finalQuote;
                fullCover = 1;
            }

            //Save current quote to database
            string dateString = DOB.ToString("MM/dd/yyyy");


            using (CarInsuranceEntities2 db = new CarInsuranceEntities2()) //db is a new instance of db model in C# classes
            {
                var _quote = new Models.InsuranceQuote(); //New instance of InsuranceQuote class, representing one entity in Insurance table in DB
                _quote.FirstName = firstName;
                _quote.LastName = lastName;
                _quote.Email = emailAddress;
                _quote.DOB = DOB;
                _quote.CarMake = make;
                _quote.CarModel = model;
                _quote.CarYear = year;
                _quote.Tickets = tickets;
                _quote.FullCoverage = fullCover;
                _quote.Quote = finalQuote;

                db.InsuranceQuotes.Add(_quote); //Adds the signup instance to the C# table model
                db.SaveChanges(); //Applies changes to DB
            }

            finalQuote = System.Math.Round(finalQuote, 2);
            return View(finalQuote);
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "Here is a list of all quotes issued.";

            using(CarInsuranceEntities2 db = new CarInsuranceEntities2())
            {
                var quoteViews = new List<Models.InsuranceQuote>();
                var dbQuotes = new List<InsuranceViewModels>();

                quoteViews = (from c in db.InsuranceQuotes select c).ToList(); //LINQ statement to select all quote rows
                foreach(Models.InsuranceQuote quote in quoteViews)
                {
                    var quoteView = new InsuranceViewModels();
                    quoteView.firstName = quote.FirstName;
                    quoteView.lastName = quote.LastName;
                    quoteView.email = quote.Email;
                    var strQuote = System.Math.Round((double)quote.Quote, 2);
                    quoteView.quote = strQuote;

                    dbQuotes.Add(quoteView);
                }
                return View(dbQuotes);
            }

        }
    }
}