using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JayaKaryaAPI.Models
{
    public class Product
    {
        // Id, Name, Price, Stock
        public int Id { set; get; }
        public String Name { set; get; }
        public double Price { set; get; }
        public int Stock { set; get; }
    }
}