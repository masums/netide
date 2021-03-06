﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetIde.Shell.Interop
{
    public interface INiIterator<T> : IDisposable
    {
        HResult GetCurrent(out T current);
        HResult Next(out bool available);
    }
}
