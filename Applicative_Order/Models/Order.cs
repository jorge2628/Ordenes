using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class Order
    {
        [Key]
        public int orderID { get; set; }

        public string numberOrder { get; set; }

        public int idCarrier { get; set; }

        public int numberStems { get; set; }

        public string typeDescription { get; set; }

        public string measures { get; set; }

        public int BoxType { get; set; }

        public int BoxNumer { get; set; }

        public string AWB { get; set; }



        [Display(Name = "Protocol")]
        public bool protocol { get; set; }


        [Display(Name = "Prize")]
        public float prize { get; set; }

        public float total { get; set; }


        [Required]
        /* [Column(TypeName = "Date")]*/
        [DataType(DataType.Date)]
        [Display(Name = "Ship Date Miami")]



        public DateTime ShipDateMiami { get; set; }

        [Required]
        public int orderTypeID { get; set; }
        [Required]
        public int customerID { get; set; }


        public int BunchPerBox { get; set; }


        [Required]
        public int productGalleriaID { get; set; }

       
        public virtual OrderType orderType { get; set; }

        public virtual Customer customer { get; set; }

        public virtual ProductGalleria productGalleria { get; set; }

        public virtual ICollection<Farm> Farms { get; set; }

        public virtual ICollection<Protocol> Protocols { get; set; }



    }
}