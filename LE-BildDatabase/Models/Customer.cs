using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LE_BildDatabase.Models
{
    public class Customer
    {

        public int Id { get; set; }//kundnummret
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Phone { get; set; }
        public int Invoice { get; set; }//faktnr

        // public<List> Photo { get; set; }
        public List<Photo> Photos { get; set; }
        //List<Photo> Photo = new List<Photo>();
    }
}
