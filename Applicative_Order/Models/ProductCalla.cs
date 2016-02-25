using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class ProductCalla
    {
        [Key]
        public int productCallaID { get; set; }


        [Required]
        [Display(Name = "Name Product")]
        public string nameProduct { get; set; }

        public virtual ICollection<Recipe> recipes { get; set; }
    }
}