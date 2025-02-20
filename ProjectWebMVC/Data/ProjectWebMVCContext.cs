using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectWebMVC.Models;

namespace ProjectWebMVC.Data
{
    public class ProjectWebMVCContext : DbContext
    {
        public ProjectWebMVCContext (DbContextOptions<ProjectWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
