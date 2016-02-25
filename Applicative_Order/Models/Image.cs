using Applicative_Order.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AplicativoPedido.Models
{
    public class Image
    {
        [Key]
        public int imageID { get; set; }

      
        public string description { get; set; }

        public int recipeID { get; set; }

        public virtual Recipe recipe { get; set; }

        [Column(TypeName = "image")]
        public byte[] image { get; set; }



    }
}