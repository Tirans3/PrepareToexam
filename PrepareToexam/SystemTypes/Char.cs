using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTypes
{
   public class Char
    {
        // Inheritance Object -> ValueType -> Char
        // Aliase in C# is char.
        // Range from U+0000 to U+FFFF.
        // Size is 2 byte(16 bit).
        // Default value is '\0';
        readonly char c=default(char);
        public char chA = 'A';
		char ch1 = '1';
		public void display()
            {
             Console.WriteLinechA.CompareTo('B'));			// Output: "-1" (meaning 'A' is 1 less than 'B')
		     Console.WriteLine(chA.Equals('A'));			// Output: "True"
		     Console.WriteLine(Char.GetNumericValue(ch1));	// Output: "1"
		     Console.WriteLine(Char.IsControl('\t'));		// Output: "True"
		     Console.WriteLine(Char.IsDigit(ch1));			// Output: "True"
		     Console.WriteLine(Char.IsLetter(','));			// Output: "False"
		     Console.WriteLine(Char.IsLower('u'));			// Output: "True"
		     Console.WriteLine(Char.IsNumber(ch1));			// Output: "True"
		     Console.WriteLine(Char.IsPunctuation('.'));	// Output: "True"
		     Console.WriteLine(Char.IsSeparator(str, 4));	// Output: "True"
		     Console.WriteLine(Char.IsSymbol('+'));			// Output: "True"
		     Console.WriteLine(Char.IsWhiteSpace(str, 4));	// Output: "True"
		     Console.WriteLine(Char.Parse("S"));			// Output: "S"
		     Console.WriteLine(Char.ToLower('M'));			// Output: "m"
		     Console.WriteLine('x'.ToString());				// Output: "x"		
        }
		
    }
}
