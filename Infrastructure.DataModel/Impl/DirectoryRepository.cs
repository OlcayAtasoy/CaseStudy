using Infrastructure.DataModel.Entities;
using Infrastructure.DataModel.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Directory GetDirectoryWithRelations(Guid id)
        {
            Directory directory = _context.Directory
                .Include(x => x.CommunicationInformation)

                .FirstOrDefault(x => x.Id == id);

            return directory;
        }

    }
}
