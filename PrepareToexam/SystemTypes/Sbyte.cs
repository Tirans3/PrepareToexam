namespace SystemTypes
{
    class Sbyte
    {
        // Inheritance Object -> ValueType -> SByte.
        // Aliase in C# is sbyte.
        // Range from -128 to 127.
        // Size is 1 byte.
        // Default value is 0.
        readonly sbyte Default = 0;
        readonly sbyte min = sbyte.MinValue;// -128;
        readonly sbyte max = sbyte.MaxValue;// 127;
    }
}
