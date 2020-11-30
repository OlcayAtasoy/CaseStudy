using Infrastructure.DataModel.Entities;
using Infrastructure.DataModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataModel.Impl
{
    public class DirectoryRepository : Repository<Directory>, IDirectoryRepository
    {
        public MyDbContext _context;
        public DirectoryRepository(MyDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
