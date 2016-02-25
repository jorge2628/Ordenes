using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class Recipe
    {

        [Key]
        public int recipeID { get; set; }

        [Display(Name = "Name Recipe")]
        public string nameRecipe { get; set; }

        public int numberBunch { get; set;}

        public int numberStemsPerBunch { get; set; }

        public int productCallaID { get; set; }

        public virtual ProductCalla productCalla { get; set; }

        public virtual ICollection<Protocol> protocol { get; set; }

    }
}