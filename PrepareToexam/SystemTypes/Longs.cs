using System;
namespace SystemTypes
{
    class Longs
    {
        // Inheritance Object -> ValueType ->Int64.
        // Aliase in C# is long.
        // Size Signed 64-bit integer.
        // Range from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        // Default value is 0L. 
        // int x = 8L;           Error: no implicit conversion from long to int
        int y = (int)8L;      // OK: explicit conversion to int
        // long x = 3.0;         Error: no implicit conversion from double
        long z = (long)3.0;   // OK: explicit conversion
    }
}
