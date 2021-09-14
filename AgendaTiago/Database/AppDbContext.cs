using AgendaTiago.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTiago.Database
{
    public class AppDbContext : DbContext
    {
            public virtual DbSet<Schedule>  Person { get; set; }
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            { }
    }
}

