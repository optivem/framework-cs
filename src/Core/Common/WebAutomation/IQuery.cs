﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Framework.Core.Common.WebAutomation
{
    public interface IQuery
    {
        FindType FindType { get; }

        string FindBy { get; }
    }
}