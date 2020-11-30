using Infrastructure.DataModel.Entities;
using Infrastructure.DataModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataModel.Impl
{
    public class CommunicationInformationRepository : Repository<CommunicationInformation>, ICommunicationInformationRepository
    {
        public MyDbContext _context;
        public CommunicationInformationRepository(MyDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
