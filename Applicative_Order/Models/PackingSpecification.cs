using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class PackingSpecification
    {
        [Key]
        public int packSpecID { get; set; }
        public string slizeSleeve { get; set; }
        public string positionSleeve { get; set; }

        public string positionRubber { get; set; }

        [Required]
        public int sleeveTypeID { get; set; }
        [Required]
        public int boxTypeID { get; set; }
        [Required]
        public int foodTypeID { get; set; }

        public int BunchPerBox { get; set; }

        public virtual SleeveType sleeveType { get; set; }

        public virtual BoxType boxType { get; set; }

        public virtual FoodType foodType { get; set; }

       

        public virtual ICollection<Protocol> protocols { get; set; }
    }
}