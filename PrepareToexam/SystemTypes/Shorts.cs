using System;
namespace SystemTypes
{
    class Shorts
    {
        // Inheritance Object -> ValueType ->Int16.
        // Aliase in C# is short.
        // Size Signed 16-bit integer.
        // Range from -32,768 to 32,767.
        // Default value is 0.  

        // short x = 3.0;           Error: no implicit conversion from double
           short y = (short)3.0;   // OK: explicit conversion
    }
}
