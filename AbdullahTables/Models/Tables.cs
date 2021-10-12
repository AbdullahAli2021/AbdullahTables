using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbdullahTables.Models
{
    public class Tables
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Review { get; set; }
    }
}
