using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class ProductType
    {

        [Key]
        public int idProduct { get; set; }


        public int numberStems { get; set; }

        public string descriptionProduct { get; set; }
        [Required]
        public int productGalleriaID { get; set; }

        public virtual ProductGalleria productGalleria { get; set; }




    }
}