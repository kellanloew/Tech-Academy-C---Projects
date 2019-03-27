using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InsuranceQuote.Models;

namespace InsuranceQuote.ViewModels
{
    public class InsuranceViewModels
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public double quote { get; set; }
        public int id { get; set; }
    }
}