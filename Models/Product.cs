using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApiReactJs.Models
{
    public class Product
    {
        public int idProduct { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public int idCategory { get; set; } //should have!
        public Category Category { get; set; }

    }
}
