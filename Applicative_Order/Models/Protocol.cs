using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class Protocol
    {

        [Key]
        public int protocolID { get; set; }
        [Required]

        //que hace esta clase???
        public int recipeID { get; set; }

        [Required]
        public int packSpecID { get; set; }

        [Required]
        public int bunchSpecificationID { get; set; }


        public virtual Recipe recipe { get; set; }

        public virtual PackingSpecification packingSpecifications { get; set; }

        public virtual BunchSpecification bunchSpecification { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}