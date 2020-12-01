using Infrastructure.DataModel.Entities;
using Infrastructure.DataModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataModel.Impl
{
    public class ReportRepository : Repository<Reports>, IReportRepository
    {
        public MyDbContext _context;
        public ReportRepository(MyDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
