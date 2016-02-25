using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class SleeveType
    {
        [Key]
        public int sleeveTypeID { get; set; }

        [Display(Name = "Code Sleeve Type")]
        public string codSleeveType { get; set; }


        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }

        public virtual ICollection<PackingSpecification> packingSpecification { get; set; }
    }
}