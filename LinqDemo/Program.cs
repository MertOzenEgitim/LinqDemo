#region Where

//var numbers = new List<int> { 5, 10, 15, 20, 25 };
//var filteredData = numbers.Where(x => x > 10);

//foreach (var number in filteredData)
//{
//    Console.WriteLine(number);
//}
#endregion

#region OrderBy

//var numbers = new List<int> { 10, 5,4, 20, 25 };
//var orderedData = numbers.OrderBy(x=>x);

//foreach (var number in orderedData)
//{
//    Console.WriteLine(number);
//}
#endregion

#region OrderByDescending

//var numbers = new List<int> { 10, 5, 4, 20, 25 };
//var orderedData = numbers.OrderByDescending(x => x);

//foreach (var number in orderedData)
//{
//    Console.WriteLine(number);
//}
#endregion

#region ThenBy

//var people = new List<(string FirstName,string LastName)> {
//("Mert","Özen"),
//("Mert","Deniz"),
//("Ali","Mutlu"),
//("Mehmet","Yıldırım"),
//("Mesut","Kartal")
//};
//var orderedData = people.OrderBy(x => x.FirstName)
//                        .ThenBy(y=>y.LastName);

//foreach (var person in orderedData)
//{
//    Console.WriteLine($"{person.FirstName} {person.LastName}");
//}
#endregion

#region ThenByDescending

var people = new List<(string FirstName, string LastName)> {
("Mert","Özen"),
("Mert","Deniz"),
("Ali","Mutlu"),
("Mehmet","Yıldırım"),
("Mesut","Kartal")
};
var orderedData = people.OrderBy(x => x.FirstName)
                        .ThenByDescending(y => y.LastName);

foreach (var person in orderedData)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}
#endregion

