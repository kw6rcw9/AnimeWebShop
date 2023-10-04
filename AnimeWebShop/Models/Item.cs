using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeWebShop.Models
{
    internal class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Item() { }

        public Item( string name, int  price, string description, string image)
        {
            
            Name = name;
            Price = price;
            Description = description;
            Image = image;
        }

        public string ImageSource => "/Images/" + Image;
    }
}
