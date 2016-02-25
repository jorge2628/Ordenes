using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicativoPedido.Models
{
    public class LabelUPC
    {
        public int labelUPCID { get; set; }
        public string nameUPC { get; set; }

        public string barcodeNumber { get; set;}
        public string date { get; set; }

        public string productCountry { get; set; }

        public virtual ICollection<Attach> attach { get; set; }

    }
}