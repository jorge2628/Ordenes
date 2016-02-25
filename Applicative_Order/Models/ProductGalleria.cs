using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class ProductGalleria
    {
        [Key]
        public int productGalleriaID { get; set; }

        [Required]
        public string code { get; set; }

        public string name { get; set; }


        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<ProductType> ProductTypes { get; set; }
    }
}