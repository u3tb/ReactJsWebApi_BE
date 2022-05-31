using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webApiReactJs.Models
{
    public class Category
    {
        [Key]
        public int idCategory { get; set; }
        public string Name { get; set; }
        public string SlugCategory { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
