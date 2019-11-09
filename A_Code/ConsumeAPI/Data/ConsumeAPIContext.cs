using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsumeAPI.Models
{
    public class ConsumeAPIContext : DbContext
    {
        public ConsumeAPIContext (DbContextOptions<ConsumeAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ConsumeAPI.Models.Employee> Employees { get; set; }
    }
}
