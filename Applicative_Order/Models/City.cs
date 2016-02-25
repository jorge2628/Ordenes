using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class City
    {
        [Key]
        public int cityID { get; set; }

        [Required]
        [Display(Name = "Code City")]
        public string codeCity { get; set; }

        [Required]
        [Display(Name = "Name City")]
        public string nameCity { get; set; }

        [Required]
        [Display(Name = "Country")]
        public int countryID { get; set; }

        public virtual Country country { get; set; }

    }
}