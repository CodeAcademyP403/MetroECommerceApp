using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetroEcommerceApp.Models
{
    public class Menu
    {
        public Menu()
        {
            Branches = new HashSet<Branches>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Path { get; set; }
        public IEnumerable<Branches> Branches { get; set; }
    }
}
