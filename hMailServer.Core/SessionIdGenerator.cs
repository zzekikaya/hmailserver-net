﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hMailServer.Core
{
    static class SessionIdGenerator
    {
        public static string Generate()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
