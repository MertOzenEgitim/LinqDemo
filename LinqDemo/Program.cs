//int[] numbers = [1, 2, 3, 4, 5];

////LINQ sorugusu
//var query = from number in numbers
//            where number > 2
//            select number;

//foreach (var number in query)
//{
//    Console.WriteLine(number);
//}


//string[] names = {"Mert","Mehmet","Mesut","Ali","Veli"};

////LINQ sorugusu
//var query = from name in names
//            where name.StartsWith("Me")
//            select name;

//foreach (var name in query)
//{
//    Console.WriteLine(name);
//}


int[] numbers = [1, 2, 3, 4, 5];

//LINQ sorugusu
var resultList = numbers.Where(x=>x>2).Select(y=>y*y);

foreach (var result in resultList)
{
    Console.WriteLine(result);
}