using System;
using System.Linq;
using System.Reflection;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<SampleAttribute>().Count() > 0
                        select t;

            foreach (var t in types)
            {
                Console.WriteLine(t.Name);

                foreach (var p in t.GetProperties())
                {
                    Console.WriteLine(p.Name);
                }
            }
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class SampleAttribute:Attribute
    {
        public string Name { get; set; }
        public int Version { get; set; }
    }

    [SampleAttribute(Name ="Jhone",Version =1)]
    public class Test
    {
        public int IntValue { get; set; }
        public void Method() { }
    }
    public class NoAttribute
    {

    }
}
