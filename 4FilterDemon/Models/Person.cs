using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _4FilterDemon.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public int Alder { get; set; }
        public bool ErILive { get; set; }
    }
}