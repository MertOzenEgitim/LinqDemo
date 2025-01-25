using System;

namespace LinqDemo
{    
    class Program
    {
        
        static void Main(string[] args)
        {
            //var numbers = new[] { 1, 2, 3,3, 4, 5, 5, 6 };
            //var distinctNumbers=numbers.Distinct();
            //Console.WriteLine(string.Join(",",distinctNumbers));

            //var array1=new[] { 1, 2, 3 };
            //var array2=new[] { 3,4,5 };

            //var unionArray=array1.Union(array2);
            //Console.WriteLine(string.Join(",", unionArray));

            //var intersectArray=array1.Intersect(array2);
            //Console.WriteLine(string.Join(",", intersectArray));

            //List<int> list = new List<int>{1,2,3};
            //List<int> list2 = new List<int>{3,4,5};

            //var exceptList= list.Except(list2);
            //Console.WriteLine(string.Join(",", exceptList));

            var employess = new[]
            {
                new {Id=1,Name="Mert"},
                new {Id=2,Name="Mehmet"},
                new {Id=3,Name="Mesut"},
                new {Id=4,Name="Ali"},
            };

            var departments = new[]
            {
                new{DepartmentId=1,DepartmentName="HR",EmployeeId=1},
                new{DepartmentId=2,DepartmentName="IT",EmployeeId=1},
                new{DepartmentId=3,DepartmentName="Finance",EmployeeId=2},
                new{DepartmentId=4,DepartmentName="Marketing",EmployeeId=3},
                new{DepartmentId=5,DepartmentName="Sales",EmployeeId=3},
            };

            //var result = from emp in employess
            //             join dept in departments
            //             on emp.Id equals dept.EmployeeId
            //             select new { emp.Name, dept.DepartmentName };

            //var result = employess.Join(departments,
            //    emp=>emp.Id,
            //    dept=>dept.EmployeeId,
            //    (emp,dept)=>new {emp.Name,dept.DepartmentName});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Department: {item.DepartmentName}");
            //}

            //var result = from emp in employess
            //             join dept in departments
            //             on emp.Id equals dept.EmployeeId into employeeDepartments
            //             select new { emp.Name, Departments = employeeDepartments };

            var result = employess.GroupJoin(departments,
                emp=>emp.Id,
                dept=>dept.EmployeeId,
                (emp,depts)=>new {emp.Name,Departments=depts}
                );

            foreach (var item in result)
            {
                Console.WriteLine($"Name: {item.Name}");
                foreach (var dept in item.Departments)
                {
                    Console.WriteLine($" Department: {dept.DepartmentName}");
                }
            }
        }
    }
}