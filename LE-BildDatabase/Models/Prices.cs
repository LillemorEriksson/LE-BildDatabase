using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LE_BildDatabase.Models

{
    public class Prices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal priser { get; set; }
        public List<Photo> Photos { get; set; }
    }
}