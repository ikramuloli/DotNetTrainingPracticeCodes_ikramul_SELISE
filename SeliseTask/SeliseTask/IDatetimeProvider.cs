﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SeliseTask_003
{
    public interface IDatetimeProvider
    {
        DateTime UtcNow { get; }
    }
}
