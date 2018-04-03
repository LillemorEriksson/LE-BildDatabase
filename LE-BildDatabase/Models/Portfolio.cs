using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LE_BildDatabase.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public Photo[] Photo { get; set; }
        public string Name{ get; set; }


    }
}