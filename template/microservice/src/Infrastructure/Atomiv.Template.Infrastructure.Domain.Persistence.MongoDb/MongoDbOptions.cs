﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Atomiv.Template.Infrastructure.Domain.Persistence.MongoDB
{
    public class MongoDBOptions
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
