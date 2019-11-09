
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_APIC.Model
{
    public class ApplicationDataContext: DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> dBContext) :base(dBContext)
        {

        }
        public DbSet<Employees> employees { get; set; }
    }
}
