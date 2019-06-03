using System;

namespace ValueReferenceNullableType
{
    public class Vrntypes
    {
        public void Main()
        {
            Console.WriteLine("sasa");
        }
        struct State
        {
          public  string name;
        }

        class Person
        {
         public  string name;
         public  int age;
        }

        public void Display1()
        {
            State st1 = new State();
            State st2 = new State();
            st2.name = "Hagi";
            st1 = st2;
            st2.name = "Anna";
            Console.Write(st1.name);  // Hagi
            
        }

        public void Display2()
        {
            Person st1 = new Person();
            Person st2 = new Person();
            st2.name = "Hagi";
            st1 = st2;
            st2.name = "Anna";
            Console.Write(st1.name);  // Anna

        }

        // Nullable<T>==T? for value types.

        bool b = typeof(Nullable<int>) == typeof(int?); // true.
        int? z1 = 5;
        bool? enabled1 = null;
        Double? d1 = 3.3;

        Nullable<int> z2 = 5;
        Nullable<bool> enabled2 = null;
        Nullable<double> d2 = 3.3;


    }
}
