using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oim
{
    public class Bioscoop : onderdeel
    {
        
        public string description { get; set; }
       

        public Bioscoop(string bioscoopnaam, string description, string path) : base(bioscoopnaam, path)
        {            
            this.description = description;            
        }
    }
}