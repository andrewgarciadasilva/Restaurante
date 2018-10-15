
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurante.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}