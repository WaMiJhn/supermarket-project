using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RhDalLibrary.DTO
{
    public class ItemDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageSource { get; set; }
        public UnitDTO Unit { get; set; }
        public int CategoryId { get; set; }
        public bool Available { get; set; }
    }
}
