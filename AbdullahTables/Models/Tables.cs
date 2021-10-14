using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbdullahTables.Models
{
    public class Tables
    {
        public int Id { get; set; } // id is the primaery key
        public string Name { get; set; } // name of the table
        public string Color { get; set; } // Color of the table
        public string Type { get; set; } // which category is the table ( desk ofiice room ....)
        public decimal Price { get; set; }  //Price of the Table
        public string Review { get; set; } // Customer Review
    }
}
