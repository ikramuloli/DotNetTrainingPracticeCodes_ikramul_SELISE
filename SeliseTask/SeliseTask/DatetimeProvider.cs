﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SeliseTask_003
{
    public class DatetimeProvider : IDatetimeProvider
    {
        public DateTime UtcNow 
        {
            get => DateTime.UtcNow;
        }
    }
}
