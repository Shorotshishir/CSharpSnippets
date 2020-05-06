using System;
using System.Reflection;

namespace SecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var myclass = new MyClass();
            myclass.Age = 10;
            myclass.Home = "Earth";
            var type = typeof(Environment); // MyClass is static class with static properties
            foreach (var p in type.GetProperties())
            {
                System.Console.WriteLine($"{p.Name}: {p.GetValue(null)}");
            }
            System.Console.WriteLine();
        }
    }
}
