using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoProject.Web.Models;

namespace DemoProject.Web.Data
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options)
            : base(options)
        {
        }

        public DbSet<DemoProject.Web.Models.Patient> Patient { get; set; }
    }
}
