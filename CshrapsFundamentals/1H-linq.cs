// LINQ - Language integrated Query 
// powerful feature to query collections

using LivingThings;

byte[] num = {20, 30, 50, 49, 35, 46, 57};
var evenNumberwithLinq = num.Where(number => number %2 == 0); //declearative

// List<byte> evennumbebrs = new List<byte>();
// // foreach(var number in numbers)
// // {
// //     if (number %2 ==0)
// //     {
// //         evennumbebrsNumbers.Add(number);
// //     }
// // }

//foreach(var number in evenNUmbersWithLinqe)
// {
//     Console.WriteLine(number);
// }

byte[] numbers = {11, 22, 10, 22, 35, 21, 51, 80, 55};
var oddNUmberwithLinq = numbers.Where(number => number %2 == 1);

foreach(var number in oddNUmberwithLinq)
{
    Console.WriteLine(number);
}


byte[] values = {1, 2, 3, 4, 20, 30 ,60 ,66 ,77 ,88 ,99};

var lessThanFiftyandoddNumbers = values.Where(number => number < 50 && number % 2 == 1);

foreach(var number in lessThanFiftyandoddNumbers)
{
    Console.WriteLine(number);
}

string[] names = {" apple", "ball", "cat", "bob marley"};
var nameStartingb = names.Where( x => x.StartsWith("b"));

foreach(var x in nameStartingb)
{
    Console.WriteLine(x);
}


// projections
//Get square of each wlwmwnt in "numbers" array


var squares = numbers.Select(x => x * x);

foreach(var item in squares)
{
    Console.WriteLine(item);
}

var square = from x in numbers where x > 70 select x * x;   //(expression syntax)
//var squaresGreater70 = numbers.where(x=> x > 70).select(z => z * z);  (Method syntax)
foreach (var item in squares)
{
System.Console.WriteLine(item);

}

var square_root = from x in numbers where x % 3 == 0 select Math.Sqrt(x);
var square_root3 = numbers.Where(x => x % 3 == 0).Select(y => Math.Sqrt(y)); 
foreach (var item in square_root)
{
    System.Console.WriteLine(item);
}

// Check if ANY of the number is mutiple of 7 on nubers

var multipleOf7 = numbers.Any(x => x % 7 == 0);

// Check if ALL of the number in "numbers"  are mutiple of 7

var allMultipleOf7 = numbers.All(x => x % 7 == 0);

// first five numbers item in numbers

var first5 = numbers.Take(5);

// Skip first five and get next five

numbers.Skip(5).Take(5);
var skip2AndgGetNext5 = numbers.Skip(2).Take(5);

//Get all the people who are adult now

//var adults = people.where(x => x.age > 18);


