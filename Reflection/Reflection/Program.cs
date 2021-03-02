using System;
using System.Linq;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            //Console.WriteLine(assembly.FullName);

            //var types = assembly.GetTypes();
            //foreach (var type in types)
            //{
            //    Console.WriteLine("Type : " + type.Name + " Base Type:" + type.BaseType);
            //    var props = type.GetProperties();
            //    foreach (var prop in props)
            //    {
            //        Console.WriteLine("\tProperty: " + prop.Name + " PropertyType: " + prop.PropertyType);
            //    }
            //    var methods = type.GetMethods();
            //    foreach (var method in methods)
            //    {
            //        Console.WriteLine("\tMethod: " + method.Name);
            //    }
            //}
            //var sample = new Sample();
            //sample.Name = "Jhon";
            //sample.Age = 24;
            //var SampleType = typeof(Sample);

            //var nameProperty = SampleType.GetProperty("Name");
            //Console.WriteLine("Property : "+nameProperty.GetValue(sample));

            //var myMethod = SampleType.GetMethod("MyMethod");

            //myMethod.Invoke(sample, null);

            var typess = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyClassAttribute>().Count() > 0);
            foreach (var type in typess)
            {
                Console.WriteLine(type.Name);

                var methods = type.GetMethods().Where(m => m.GetCustomAttributes<MyMethodAttribute> ().Count() > 0);
                foreach (var method in methods)
                {
                    Console.WriteLine(method.Name);
                }
            }
        }
    }
    [MyClass]
    public class Sample
    {
        public string Name { get; set; }
        public int Age;
        [MyMethod]
        public void MyMethod()
        {
            Console.WriteLine("Hello from Method");
        }
        public void NoAttributeMethod() { }
    }
    [AttributeUsage(AttributeTargets.Class)]
    public class MyClassAttribute : Attribute { }
    [AttributeUsage(AttributeTargets.Method)]
    public class MyMethodAttribute : Attribute { }
}
