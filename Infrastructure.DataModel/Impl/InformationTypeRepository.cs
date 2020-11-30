using Infrastructure.DataModel.Entities;
using Infrastructure.DataModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataModel.Impl
{
    public class InformationTypeRepository : Repository<InformationType>, IinformationTypeRepository
    {
        public MyDbContext _context;
        public InformationTypeRepository(MyDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
