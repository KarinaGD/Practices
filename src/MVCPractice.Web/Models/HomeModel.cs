using MVCPractice.Data.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPractice.Web.Models
{
    public class HomeModel
    {
        public List<Product> Products { get; set; }
    }
}