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


Animal x = new Animal();
x.domestic = true;
x.numberOfLegs = 6;


Animal x1 = new Animal();
a1.domestic = true;
a1.numberOfLegs = 4;

Animal x2 = new Animal();
b2.domestic = false;
b2.numberOfLegs = 6;

Animal x3 = new Animal();
c3.domestic = true;
c3.numberOfLegs = 5;

Animal x4 = new Animal();
d4.domestic = false;
d4.numberOfLegs = 8;

Animal x5 = new Animal();
e5.domestic = false;
e5.numberOfLegs = 12;

Animal x6 = new Animal();
f6.domestic = true;
f6.numberOfLegs = 7;



Animal[] animals = { x, x1, x2, x3, x4, x5, x6 };

var domesticAnimal = animals.Where(x => x.domestic == true);
foreach (var item in domesticAnimal)
{
    System.Console.WriteLine(item);
    System.Console.WriteLine(item);
}

var square_root = from x in numbers where x % 3 == 0 select Math.Sqrt(x);
foreach (var item in square_root)
    System.Console.WriteLine(".......................");
var ahmt4l = animals.Where(x => x.numberOfLegs > 4);
foreach (var item in ahmt4l)
{
    System.Console.WriteLine(item);
}
40
csharpfundamentals / 1IAnimal.cs
@@ -0,0 + 1,40 @@
namespace LivingThings;
class Animal
{
    // Parameterless constructor - default
    public Animal()
    {
    }

    // Parameterized constructor
    public Animal(string animalCategory, byte legs)
    {
        category = animalCategory;
        numberOfLegs = legs;
    }

    public Animal(string animalCategory, byte legs, string sn, bool d)
    {
        category = animalCategory;
        numberOfLegs = legs;
        domestic = d;
        scientificName = sn;
    }

    public string category;
    public string scientificName;
    public byte numberOfLegs;
    public bool domestic;
}
