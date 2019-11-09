using LIveAPIDemoV3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIveAPIDemoV3
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)

        {
        }

        //public ApplicationDbContext()
        //{

        //}
        public DbSet<Employee> employees { get; set; }
    }

}