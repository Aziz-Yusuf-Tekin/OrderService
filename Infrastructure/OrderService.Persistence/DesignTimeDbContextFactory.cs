using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OrderService.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<OrderServiceContext>
    {
        public OrderServiceContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<OrderServiceContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
