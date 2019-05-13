using System;
namespace SystemTypes
{
    class Strings
    {
        // Inheritance Object -> String.
        // Aliase in C# is string.
        // Size 4 byte for adress.
        // Default value is null. 
        // string is immutable.
        public void Display()
        {
            string a = "hello";
            string b = "h";
            b += "ello";
            bool t = a == b;                     // True
            string str = "test";
            char x = str[2];                     // x = 's';
            string s = @"c:\Docs\Source\a.txt";  // rather than "c:\\Docs\\Source\\a.txt"
        }
       
    }
}
