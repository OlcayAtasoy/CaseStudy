﻿using Infrastructure.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataModel.Interface
{
    public interface IDirectoryRepository : IRepository<Directory>
    {
        Directory GetDirectoryWithRelations(Guid id);
    }
}
