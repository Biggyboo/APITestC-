using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APITest.Context;

namespace APITest.Models
{
    public class APITestContext : DbContext
    {
        public APITestContext (DbContextOptions<APITestContext> options)
            : base(options)
        {
        }

        public DbSet<APITest.Context.Test> Test { get; set; }
    }
}
