namespace COMP2007_S2016_Lesson10C.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodContext : DbContext
    {
        public FoodContext()
            : base("name=FoodConnnection")
        {
        }

        public virtual DbSet<Food> Food { get; set; }
    }
}
