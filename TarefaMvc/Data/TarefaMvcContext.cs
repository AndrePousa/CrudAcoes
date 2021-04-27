using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TarefaMvc.Models;

namespace TarefaMvc.Data
{
    public class TarefaMvcContext : DbContext
    {
        public TarefaMvcContext (DbContextOptions<TarefaMvcContext> options)
            : base(options)
        {
        }

        public DbSet<TarefaMvc.Models.Acoes> Acoes { get; set; }
    }
}
