﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GeneralAccess.Core.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAsync();
    }
}
