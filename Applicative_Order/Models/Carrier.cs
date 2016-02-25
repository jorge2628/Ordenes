using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class Carrier
    {
        [Key]
        public int idCarrier { get; set; }

        [Required]
        [Display(Name = "Code Carrier")]
        public string codCarrier { get; set; }

        [Required]
        [Display(Name = "Name Carrier")]
        public string nameCarrier { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}