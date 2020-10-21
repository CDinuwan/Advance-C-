using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);

            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine("Type : " + type.Name);
                var props = type.GetProperties();
                foreach (var prop in props)
                {
                    Console.WriteLine("\tProperty: "+prop.Name+" PropertyType: "+prop.PropertyType);
                }
                var methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("\tMethod: "+method.Name);
                }
            }
        }
    }
    public class Sample
    {
        public string Name { get; set; }
        public int Age;
        public void MyMethod()
        {

        }
    }
}
