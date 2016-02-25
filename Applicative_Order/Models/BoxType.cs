using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class BoxType
    {
        [Key]
        public int boxTypeID { get; set; }

        [Required]
        [Display(Name = "Code Box")]
        public string codeBox { get; set; }


        [Required]
        [Display(Name = "High")]
        public int high { get; set; }



        [Required]
        [Display(Name = "Length")]

        public int length { get; set; }



        [Required]
        [Display(Name = "Width")]
        public int width { get; set; }


        [Display(Name = "Description")]
        public string description { get; set; }

        [Display(Name = "Number max Bunch")]
        public int numMaxBunch { get; set; }


        public virtual ICollection<PackingSpecification> packingSoecification { get; set; }


    }
}