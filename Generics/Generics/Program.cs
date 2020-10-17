using System;
using System.Reflection.PortableExecutable;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = new ResultInt { Success = true, Data = 5 };
            //Console.WriteLine(result.Success);
            //Console.WriteLine(result.Data);
            //var result1 = new ResultInt { Success = false, Data = 5 };
            //Console.WriteLine(result1.Success);

            var result = new Result<int,string>{ Success = true,Data=5,Data2="Hello"};
            var result1 = new Result<string, bool> { Success = false, Data = "Jhone", Data2 = true };

            Console.WriteLine(result.Data2);
            Console.WriteLine(result1.Success);

            var helper = new ResultPrinter();
            helper.Print(result);
        }
        
    }
    public class Result<T,U>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public U Data2 { get; set; }
    }
    public class ResultPrinter
    {
        public void Print<T,U>(Result<T,U> result)
        {
            Console.WriteLine(result.Data2);
        }
    }
    //public class ResultInt
    //{
    //    public bool Success { get; set; }
    //    public int Data { get; set; }
    //}
    //public class ResultString
    //{
    //    public bool Success { get; set; }
    //    public int Data { get; set; }
    //}
}
