using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LE_BildDatabase.Models
{
    public class About
    {
        public int Id { get; set; }

        List<Contact> Photo = new List<Contact>();
    }
}