#region LINQ with Array
//string[] fruits = { "Elma", "Armut", "Kivi", "Muz", "Kiraz" };

//var fruitsStartingWithK=from fruit in fruits
//                        where fruit.StartsWith("K")
//                        select fruit;

////foreach (var fruit in fruitsStartingWithK)
////{
////    Console.WriteLine(fruit);
////}


//var fruitsStartingWithKLambda = fruits.Where(f => f.StartsWith("K"));
//foreach (var fruit in fruitsStartingWithKLambda)
//{
//    Console.WriteLine(fruit);
//}
#endregion

#region LINQ with List
//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//var evenNumbers=from number in numbers
//                where number%2==0
//                select number;
////foreach(var number in evenNumbers)
////{
////    Console.WriteLine(number);
////}

//var evenNumbersLambda=numbers.Where(number=>number%2==0);
//foreach(var number in evenNumbersLambda)
//{
//    Console.WriteLine(number);
//}

#endregion

#region LINQ with Dictionary

Dictionary<int,string> students = new Dictionary<int,string>{
    {1,"Ali"},
    {2,"Mert"},
    {3,"Mehmet"},
    {4,"Mesut"},
};

var studentsStartingWithM=from student in students
                          where student.Value.StartsWith("M")
                          select student;

//foreach (var student in studentsStartingWithM)
//{
//    Console.WriteLine($"{student.Key},{student.Value}");
//}

var studentsStartingWithMLambda=students.Where(x=>x.Value.StartsWith("M"));

foreach (var student in studentsStartingWithMLambda)
{
    Console.WriteLine($"{student.Key},{student.Value}");
}

#endregion
