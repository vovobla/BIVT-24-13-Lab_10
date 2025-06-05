﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public interface IPerson
    {
        string FullName { get; }
        int Age { get; }
        Gender Gender { get; }
    }
}
