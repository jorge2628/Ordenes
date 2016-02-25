using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class Country
    {
        [Key]
        public int countryID { get; set; }

     
        [Required]
        [Display(Name = "Code Country")]
        public string codeCountry { get; set; }


        [Required]
        [Display(Name = "Name Country")]
        public string nameCountry { get; set; }


        public virtual ICollection<Farm> Farms { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}