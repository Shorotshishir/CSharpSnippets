using System;
using System.Reflection;

namespace SecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Non-Static Class
            var myclass = new MyClass();
            myclass.Age = 10;
            myclass.Home = "Earth";
            System.Console.WriteLine($"Printing attribute data from MyClass,{myclass.MyMessage()}");
            foreach (var p in typeof(MyClass).GetProperties())
            {
                System.Console.WriteLine($"{p.Name}: {p.GetValue(myclass,null)}");
            }

            System.Console.WriteLine("Showing Your pc's information using Environment Class's attributes");
             // var type = typeof(Environment); // Environment is static class with static properties
            // Static Class
            foreach (var p in typeof(Environment).GetProperties())
            {
                System.Console.WriteLine($"{p.Name}: {p.GetValue(null)}");
            }
        }
    }
}
