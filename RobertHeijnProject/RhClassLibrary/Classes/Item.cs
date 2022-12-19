using RhClassLibrary.Interfaces;
using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Classes
{
    public class Item
    {
        private int id;
        private string name;
        private decimal price;
        private string imagesource;
        private Unit unit;
        private bool available;
        public Item() { }
        public Item(ItemDTO itemDTO)
        {
            this.id = itemDTO.ID;
            this.name = itemDTO.Name;
            this.price = itemDTO.Price;
            this.imagesource = itemDTO.ImageSource;
            this.unit = new Unit(itemDTO.Unit);
            this.available = itemDTO.Available;
        }

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public decimal Price { get { return price;} }
        public string ImageSource { get { return imagesource; } }
        public Unit Unit { get { return unit; } }
        public bool Available { get { return available; } }
    }
}
