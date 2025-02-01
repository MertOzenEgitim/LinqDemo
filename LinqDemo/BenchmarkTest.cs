using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Runtime.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    [MemoryDiagnoser]
    public class BenchmarkTest
    {
        List<Person> personList;
        [GlobalSetup]
        public void GlobalSetup()
        {
            personList = new List<Person>
            {
                new Person
                {
                    FirstName="Mert",
                    LastName="Özen",
                    Age=30,
                    City="İstanbul"
                },
                new Person
                {
                    FirstName="Mehmet",
                    LastName="Özen",
                    Age=28,
                    City="Ankara"
                },
                new Person
                {
                    FirstName="Ali",
                    LastName="Veli",
                    Age=28,
                    City="Kastamonu"
                },
                new Person
                {
                    FirstName="Mesut",
                    LastName="Özen",
                    Age=26,
                    City="İzmir"
                }
            };
        }
        //[Benchmark]
        //public List<Person> FilteredList()
        //{
        //    var filteredPersonList = personList.Where(x => x.Age > 26).ToList();

        //    filteredPersonList=filteredPersonList.Where(x => x.Age < 30).ToList();

        //    return filteredPersonList;
        //}
        //[Benchmark]
        //public List<Person> FilteredListOptimized()
        //{
        //    var filteredPersonList = personList.Where(x => x.Age > 26 && x.Age < 30).ToList();

        //    return filteredPersonList;
        //}

        //[Benchmark]
        //public List<Person> OrderedList()
        //{
        //    var orderedPersonList = personList.OrderByDescending(x=>x.Age).Where(x => x.Age > 26).ToList();

        //    orderedPersonList = orderedPersonList.Where(x => x.Age < 30).ToList();

        //    return orderedPersonList;
        //}
        //[Benchmark]
        //public List<Person> OrderedListOptimized()
        //{
        //    var orderedPersonList = personList.Where(x => x.Age > 26 && x.Age < 30).OrderByDescending(x=>x.Age).ToList();

        //    return orderedPersonList;
        //}

        [Benchmark]
        public List<PersonDto> ProjectList()
        {
            var projectedPersonList = personList.OrderByDescending(x => x.Age)
                .Select(y => new PersonDto { FirstName = y.FirstName, LastName = y.LastName, Age = y.Age })
                .Where(x => x.Age > 26).ToList();

            projectedPersonList = projectedPersonList.Where(x => x.Age < 30).ToList();

            return projectedPersonList;
        }
        [Benchmark]
        public List<PersonDto> ProjectListOptimized()
        {
            var projectedPersonList = personList.Where(x => x.Age > 26 && x.Age < 30)
                .Select(y => new PersonDto { FirstName = y.FirstName, LastName = y.LastName, Age = y.Age })
                .OrderByDescending(x => x.Age).ToList();

            return projectedPersonList;
        }
    }
}
