using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oim
{
    public class onderdeel
    {
        public string naam { get; set; }
        public string path { get; set; }

        public onderdeel(string naam, string path)
        {
            this.naam = naam;
            this.path = path;
        }
         
    }
}