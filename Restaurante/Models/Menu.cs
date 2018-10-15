using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurante.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Preco { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}