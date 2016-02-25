using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class BunchSpecification
    {
        [Key]
        public int bunchSpecificationID { get; set; }
        public string length { get; set; }

        public string thickness { get; set; }

        public string cut { get; set; }

        public string defoliation { get; set; }

        public string foliage { get; set; }

        public virtual ICollection<Protocol> protocols { get; set; }
    }
}