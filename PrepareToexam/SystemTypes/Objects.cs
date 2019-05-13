using System;
namespace SystemTypes
{
    class Objects
    {
        /*
          The object type is an alias for Object in .NET.
          In the unified type system of C#,all types, 
          predefined and user-defined, reference types and value types, inherit 
          directly or indirectly from Object. 
          You can assign values of any type to variablesof type object.
          When a variable of a value type is converted to object, it is said to be boxed.
          When a variable of type object is converted to a value type, it is said to be unboxed.
        */
        class ObjectTest
        {
            public int i = 10;
        }

        class MainClass2
        {
            static void Dispplay()
            {
                object a;
                a = 1;   // an example of boxing
                Console.WriteLine(a);            // 1
                Console.WriteLine(a.GetType());  // System.Int32
                Console.WriteLine(a.ToString()); // 1

                a = new ObjectTest();
                ObjectTest classRef;
                classRef = (ObjectTest)a;
                Console.WriteLine(classRef.i);   // 10
            }
        }
    }
}
