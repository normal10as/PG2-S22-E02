using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationAsFlagsCs
{
    [Flags]
    enum FileAttributeEnum
    {
        System = 1, // 1
        Read = 1 << 1,  // 2
        Write = 1 << 2, // 4
        Executable = 1 << 3,    // 8
        Hidden = 1 << 4,    // 16
        Folder = 1 << 5,    // 32
    }
}