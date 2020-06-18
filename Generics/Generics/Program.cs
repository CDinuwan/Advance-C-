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
        }
        
    }
    public class Result<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public int Data2 { get; set; }
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
