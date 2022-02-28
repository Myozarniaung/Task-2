using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orderconsumerapi.Models
{
    public class orderconsumerDBContext: DbContext
    {
        public orderconsumerDBContext(DbContextOptions<orderconsumerDBContext> options)
        : base(options)
        {
        }

        public DbSet<orderconsumer> orderconsumer { get; set; }
    }
}

