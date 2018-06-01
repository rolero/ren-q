using renq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace renq.models
{
    public class Product
    {
        public int ProductId { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        [StringLength(100)]
        public string ProdExtId { get; set; }
        [StringLength(255), Required]
        public string Name { get; set; }
        public DateTime UpdDT { get; set; }
        public DateTime CrDT { get; set; }
    }

}