using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class Farm
    {
        [Key]
        public int farmID { get; set; }

        [Display(Name = "Country")]
        public int countryID { get; set; }



        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }


        [Required]
        [Display(Name = "Code Farm")]
        public string codFarm { get; set; }


        [Required]

        [Display(Name = "City")]
        public string city { get; set; }

        
        public virtual Country country { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}