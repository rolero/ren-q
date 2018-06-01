using renq.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace renq.Models
{
    public class Supplier

    {
        public int SupplierId { get; set; }
        [StringLength(255), Required]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
