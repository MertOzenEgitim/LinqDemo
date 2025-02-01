using BenchmarkDotNet.Running;
using System;

namespace LinqDemo
{    
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    public class PersonDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers=new List<int> { 1,2,3,4,5,6,7,8,9,10};
            // //var query = numbers.Where(x => x > 2);
            // //query = query.Where(x => x < 7);

            // var query = numbers.Where(x => x > 2 && x < 7);

            // var result = numbers.Where(x => x > 2).ToList();
            // var result2 = numbers.Where(x => x < 7).ToList();

            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }

            BenchmarkRunner.Run<BenchmarkTest>();
        }
    }
}