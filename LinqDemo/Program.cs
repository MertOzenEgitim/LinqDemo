using System;

namespace LinqDemo
{    
    class Program
    {
        
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var result = numbers.Count();
            //var result = numbers.Sum();
            //var result = numbers.Average();
            //var result = numbers.Min();
            var result = numbers.Max();

            Console.WriteLine(result);
        }
    }
}