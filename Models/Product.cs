using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webApiReactJs.Models
{
    public class Product
    {
        [Key]
        public int idProduct { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public int CategoryId { get; set; } //should have!
        public Category Category { get; set; }

    }
}
