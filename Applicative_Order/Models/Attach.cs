using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AplicativoPedido.Models
{
    public class Attach
    {
        [Key]
        public int attachID { get; set; }

        public int labelUPCID { get; set; }

        public virtual LabelUPC labelUPC { get; set; }

    }
}