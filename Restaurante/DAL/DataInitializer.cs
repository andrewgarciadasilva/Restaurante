using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Restaurante.Models;

namespace Restaurante.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataBase>
    {
        protected override void Seed(DataBase context)
        {
            var restaurants = new List<Restaurant>
            {
            new Restaurant{ ID=1,Name="Meu Bistro" },
            };

            restaurants.ForEach(s => context.Restaurants.Add(s));
            context.SaveChanges();

            var menus = new List<Menu>
            {
            new Menu{ RestaurantID=1,Name="Macarrão",Preco = "30,00" }
            };
            menus.ForEach(s => context.Menus.Add(s));
            context.SaveChanges();
        }
    }
}