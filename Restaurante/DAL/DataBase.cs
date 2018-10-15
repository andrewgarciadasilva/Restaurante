using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Restaurante.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Restaurante.DAL
{
    public class DataBase : DbContext
    {
        public DataBase() : base("DataBase")
        {
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}