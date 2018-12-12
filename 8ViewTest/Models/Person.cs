using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _8ViewTest.Models
{
    public class Person
    {
        [Display(Name = "Navn på person")]
        public string Navn { get; set; }
        public int Alder { get; set; }
        public bool ErILive { get; set; }
    }
}