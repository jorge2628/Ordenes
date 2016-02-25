using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class FoodType
    {

        [Key]
        public int foodTypeID { get; set; }

        [Display(Name = "Code")]
        public string code { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }

        public virtual ICollection<PackingSpecification> packingSpecification { get; set; }

    }
}