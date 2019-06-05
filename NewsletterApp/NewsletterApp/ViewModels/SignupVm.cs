using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsletterApp.ViewModels
{
    public class SignupVm //This is the class that is actually presented to user on view
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int Id { get; set; }
    }
}