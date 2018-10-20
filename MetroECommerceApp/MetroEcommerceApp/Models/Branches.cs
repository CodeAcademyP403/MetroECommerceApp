using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroEcommerceApp.Models
{
    public class Branches
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Menu Menu { get; set; }
        public int MenuId { get; set; }
      
    }
}
