using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LE_BildDatabase.Models

{
    public class Prices
    {
        public int Id { get; set; }
        List<Photo> Photo = new List<Photo>();
        public Decimal priser { get; set; }
    }
}