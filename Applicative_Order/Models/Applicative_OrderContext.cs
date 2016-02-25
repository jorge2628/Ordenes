using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Applicative_Order.Models
{
    public class Applicative_OrderContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Applicative_OrderContext() : base("name=Applicative_OrderContext")
        {
        }

        public System.Data.Entity.DbSet<Applicative_Order.Models.Farm> Farms { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.Country> Countries { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.BoxType> BoxTypes { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.BunchSpecification> BunchSpecifications { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.FoodType> FoodTypes { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.SleeveType> SleeveTypes { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.PackingSpecification> PackingSpecifications { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.ProductCalla> ProductCallas { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.Recipe> Recipes { get; set; }

        public System.Data.Entity.DbSet<AplicativoPedido.Models.Image> Images { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.Protocol> Protocols { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.ProductGalleria> ProductGallerias { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.Carrier> Carriers { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.Seller> Sellers { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.OrderType> OrderTypes { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.Order> Orders { get; set; }

   

        public System.Data.Entity.DbSet<Applicative_Order.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<AplicativoPedido.Models.LabelUPC> LabelUPCs { get; set; }

        public System.Data.Entity.DbSet<AplicativoPedido.Models.Attach> Attaches { get; set; }

        public System.Data.Entity.DbSet<Applicative_Order.Models.ProductType> ProductTypes { get; set; }
    }
}
