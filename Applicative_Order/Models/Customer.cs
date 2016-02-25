using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class Customer
    {
        [Key]
        public int customerID { get; set; }

       
        [Display(Name = "Nit Customer")]
        public string nitCustomer { get; set; }
        [Required]
        [Display(Name = "Company")]
        public string company { get; set; }
   
        [Display(Name = "Address")]
        public string address { get; set; }
        [Display(Name = "Contact Name")]
        public string contactName { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Phone")]
        public string phone { get; set; }

        public virtual ICollection<Seller> Sellers { get; set; }
        public virtual ICollection<Carrier> Carriers { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}