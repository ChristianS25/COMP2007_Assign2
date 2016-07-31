namespace COMP2007_S2016_Lesson10C.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodStoreContext : DbContext
    {
        public FoodStoreContext()
            : base("name=MusicStoreConnection")
        {
        }

        public virtual DbSet<Food> Foods { get; set; }
        //public virtual DbSet<Menu> Menus { get; set; }

    }
}
