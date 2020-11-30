using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataModel.Entities
{
    public class ReadDbContext : BaseDbContext<ReadDbContext>
    {
        public ReadDbContext(DbContextOptions<ReadDbContext> options, IServiceProvider serviceProvider) : base(options, serviceProvider)
        {
            //mssql yapılarda rapor tool icin kullanılabilir read db den kayıt yaptıgımız ana db yormadan sadece rapoları cekebiliri.Örnek olamsı adına belirttim,
        }
    }
}
