using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4netAndJson_GitHub
{
   public class Product
    {
        public string name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double price { get; set; }
        public string[] Sizes { get; set; }
    }   
}
