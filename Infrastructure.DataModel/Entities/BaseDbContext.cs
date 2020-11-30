using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataModel.Entities
{
    public class BaseDbContext<T> : DbContext where T : DbContext
    {
        private IServiceProvider _serviceProvider;
        public BaseDbContext(DbContextOptions<T> options, IServiceProvider serviceProvider) : base(options)
        {
            this._serviceProvider = serviceProvider;

        }

    }
}
