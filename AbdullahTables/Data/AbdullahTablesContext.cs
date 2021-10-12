using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AbdullahTables.Models;

namespace AbdullahTables.Data
{
    public class AbdullahTablesContext : DbContext
    {
        public AbdullahTablesContext (DbContextOptions<AbdullahTablesContext> options)
            : base(options)
        {
        }

        public DbSet<AbdullahTables.Models.Tables> Tables { get; set; }
    }
}
