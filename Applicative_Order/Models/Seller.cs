using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class Seller
    {
        [Key]
        public int idSeller { get; set; }

        [Display(Name = "ID Seller")]
        public int identSeller { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Phone")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}