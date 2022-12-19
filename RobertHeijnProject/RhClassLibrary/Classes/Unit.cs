using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Classes
{
    public class Unit : Attribute
    {
        public Unit() { }
        public Unit(UnitDTO unitDTO)
        {
            this.id = unitDTO.Id;
            this.name = unitDTO.Name;
        }
    }
}
