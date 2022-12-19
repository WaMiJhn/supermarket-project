using RhDalLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhClassLibrary.Classes
{
    public class Category : Attribute
    {
        public Category() { }
        public Category(CategoryDTO categoryDTO)
        {
            this.id = categoryDTO.Id;
            this.name = categoryDTO.Name;
        }
    }
}
