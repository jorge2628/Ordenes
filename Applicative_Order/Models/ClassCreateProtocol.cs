using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class ClassCreateProtocol
    {
        public BunchSpecification bunchSpecification { get; set; }
        public PackingSpecification packingSpecification { get; set; }

        public Recipe recipe { get; set; }


    }
}