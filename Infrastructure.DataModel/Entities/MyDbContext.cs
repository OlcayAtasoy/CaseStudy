using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataModel.Entities
{
    public class MyDbContext : BaseDbContext<MyDbContext>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options, IServiceProvider serviceProvider) : base(options, serviceProvider)
        {

        }
    }
}
