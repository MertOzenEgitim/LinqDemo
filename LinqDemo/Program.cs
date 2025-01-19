using System;

namespace LinqDemo
{
    #region Select

    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Department { get; set; }
    //}
    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        List<Employee> employees = new List<Employee>
    //        {
    //            new Employee{Id=1,Name="Mert",Department="IT"},
    //            new Employee{Id=1,Name="Mehmet",Department="Finance"},
    //            new Employee{Id=1,Name="Mesut",Department="Sales"}
    //        };

    //        var employeeList = employees.Select(e=>new { e.Name,e.Department });

    //        foreach (var employee in employeeList)
    //        {
    //            Console.WriteLine(employee.Name);
    //        }
    //    }
    //}

    #endregion

    class Student
    {
        public string Name { get; set; }
        public List<string> Courses { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{Name="Mert",Courses=new List<string>{"Math","Physics"} },
                new Student{Name="Mehmet",Courses=new List<string>{"Chemistry","Biology"}},
                new Student{Name="Mesut",Courses=new List<string>{"History","Math"}}
            };

            var allCourses = students.SelectMany(s =>s.Courses);

            foreach (var course in allCourses)
            {
                Console.WriteLine(course);
            }
        }
    }
}