using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTypes
{
    class Decimals
    {
        // Inheritance Object -> ValueType ->Decimal.
        // Aliase in C# is decimal.
        // Size 16 byte .
        // Approximate Range ±1.0 x (10 x 28) to ±7.9228 x (10 x 28).
        // Precision is 28-29 significant digits
        // Default value is 0m.
        readonly decimal d = 300;     // Convert integer to decimal.
        public void Display()         // There is no implicit conversion between other floating-point types and the decimal type. 
        {
             int y = 3;
             decimal myMoney = 1.9m;
             double x = (double)myMoney;
             myMoney = (decimal)x;
             var value= y + myMoney; // 4.9
        }
        
    }
}
