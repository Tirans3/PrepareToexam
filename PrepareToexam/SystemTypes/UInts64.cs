using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTypes
{
    class UInts64
    {
        // Inheritance Object -> ValueType ->UInt64.
        // Aliase in C# is ulong.
        // Size Unsigned 64-bit integer.
        // Range from 0 to 18,446,744,073,709,551,615
        // Default value is 0. 

         /* Error -- no implicit conversion from double:
            ulong x = 3.0;
         */
        // OK -- explicit conversion:
         ulong y = (ulong)3.0;

    }
}
