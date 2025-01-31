using System;

namespace LinqDemo
{    
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            //----Eleman Çekme İşlemleri
            //IEnumerable<int> numbers = new List<int> { 10, 21, 30, 41 };
            //var numbers2 = new List<int> {60,70,80 };
            //var emptyList = new List<int>();
            //First & FirstOrDefault
            //var result = numbers.First();//10
            //result = emptyList.FirstOrDefault();
            //Single & SingleOrDefault
            //result = numbers.Single();
            //result = emptyList.SingleOrDefault();
            //ElementAt & ElementAtOrDefault
            //result = numbers.ElementAt(1);
            //result = numbers.ElementAt(4);
            //result = numbers.ElementAtOrDefault(4);

            //------Koleksiyonları Manipüle Etme
            //Add & AddRange
            //numbers.Add(50);
            //result = numbers.ElementAtOrDefault(4);
            //Console.WriteLine(result);
            //numbers.AddRange(numbers2);
            //numbers.AddRange(new List<int> { 90,100,110});

            //Remove & RemoveAt & RemoveAll
            //numbers.Remove(20);
            //numbers.RemoveAt(5);
            //numbers.RemoveAll(x => x % 2 == 0);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Güncelleme
            //numbers=numbers.Select(x => x == 10 ? x * 2 : x);
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //--------Nested Koleksiyonlarla Çalışma
            //SelectMany
            //var numbers=new List<List<int>>{
            //    new List<int> { 1, 2, 3 },
            //    new List<int> { 4, 5, 6 }
            //};
            //var flattenList = numbers.SelectMany(x => x).ToList();
            //Console.WriteLine(string.Join(",", flattenList));
            //GroupBy
            var people = new List<Person>
            {
                new Person{Name="Mert", Age=30},
                new Person{Name="Mehmet", Age=28},
                new Person{Name="Mesut", Age=26},
                new Person{Name="Ali", Age=26},
                new Person{Name="Veli", Age=30},
            };
            var groupedByAge=people.GroupBy(p=>p.Age);
            foreach(var group in groupedByAge)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine(person.Name);
                }
            }
        }
    }
}