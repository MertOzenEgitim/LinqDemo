using System;

namespace LinqDemo
{    
    class Program
    {
        
        static void Main(string[] args)
        {
            //var numbers=new List<int> { 10,20,30,40};
            //var firstNumber=numbers.First();
            //var firstNumber=numbers.First(x=>x>10);
            //var firstNumber = numbers.First(x=>x<10);
            //var firstNumber = numbers.FirstOrDefault(x=>x<10);
            //Console.WriteLine(firstNumber);

            //var lastNumber=numbers.Last();
            //var lastNumber = numbers.Last(x=>x>40);
            //var lastNumber = numbers.Last(x => x < 40);
            //var lastNumber = numbers.LastOrDefault(x=>x>40);

            //Console.WriteLine(lastNumber);

            //var numbers=new List<int> { 10,10,30,40};
            //var numbers2=new List<int> {};

            //var singleNumber = numbers.Single(x=>x==10);
            //var singleNumber = numbers.Single(x=>x==30);
            //var singleNumber = numbers2.Single();
            //var singleNumber = numbers.SingleOrDefault(x=>x==10);

            //Console.WriteLine(singleNumber);

            //var numbers = new List<int> { 1, 2, 3, 4, 5 };
            //var firstThree=numbers.Take(3);

            //Console.WriteLine(string.Join(",",firstThree));

            //var remaning = numbers.Skip(3);
            //Console.WriteLine(string.Join(",", remaning));

            var numbers = new List<int> { 1, 2, 3, 1, 1,2,4,5 };

            //var result = numbers.TakeWhile(x => x < 3);
            //var result = numbers.Where(x => x < 3);
            //Console.WriteLine(string.Join(",", result));

            var result = numbers.SkipWhile(x => x < 3);
            Console.WriteLine(string.Join(",", result));
        }
    }
}