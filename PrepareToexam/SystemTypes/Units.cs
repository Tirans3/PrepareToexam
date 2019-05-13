namespace SystemTypes
{
    class Units
    {
        // Inheritance Object -> ValueType ->UInt32.
        // Aliase in C# is uint.
        // Size Unsigned 32-bit integer.
        //  Range from 0 to 4,294,967,295.
        // Default value is 0.                                                  
        uint uintValue1 = 3_000_000_000;                                       //3000000000
        uint uintValue2 = 0xB2D0_5E00;                                         //3000000000
        uint uintValue3 = 0b1011_0010_1101_0000_0101_1110_0000_0000;           //3000000000
      //uint uintValue4 = 0x_B2D0_5E00;                                          3000000000   C# 7.2 onwards
      //uint uintValue5 = 0b_1011_0010_1101_0000_0101_1110_0000_0000;            3000000000   C# 7.2 onwards
    }
}
