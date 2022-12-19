using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RhDalLibrary.DTO;

namespace RhClassLibrary.Classes
{
    public abstract class Attribute
    {
        protected int id;
        protected string name;
        protected Attribute() { }
        protected Attribute(OrderStatusDTO orderStatusDTO)
        {
            this.id = orderStatusDTO.Id;
            this.name = orderStatusDTO.Name;
        }
        public int Id { get { return id; } }
        public string Name { get { return name; } }
    }
}
