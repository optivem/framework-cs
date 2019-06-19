﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Core.Domain
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }

    public interface IUnitOfWorkFactory<TUnitOfWork> : IUnitOfWorkFactory
        where TUnitOfWork : IUnitOfWork
    {
        new TUnitOfWork Create();
    }
}
