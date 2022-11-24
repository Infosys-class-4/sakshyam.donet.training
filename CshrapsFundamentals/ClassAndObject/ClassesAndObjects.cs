// // c# is objecrt-oriented language

// // programming paradime
// // Procedural: c, PASCAL, BASIC, GO
// // Imperative: Go, c#, c, c++
// // Declarative: python
// // Object Oriented: C#, java, python
// // Functional: F#, Scale, Haskell
// // Dyanamic: JS, Ruby, Python
// // Static: C#,java

// // c# is multiple-paradigm language


// class People
// 

//     }
//     public string GetOutput()
//     {
//           if (Weight < 20)
//         {
//             return"your are not ready my boy";
//         }

//         else
//         {
//             return "your weight is good";
//         }

//     }
// }

// using System;

// // top level statement - implicit Main() enrtrypoint
// // conditionals - branching



// Classwork: Ask user to enter his name and convert to upper case and print on console.
// Console.Write("enter your name:");
// string yourname = Console.ReadLine();
// string UpperCase = yourname.ToUpper();
// Console.WriteLine(yourname  + " your uppercase name is " + UpperCase);






//branching statement 
//print corresponding roman number up to 5 

// Console.Write("Enter Your Number: ");
// string romanNumber = Console.ReadLine();
// byte number = byte.Parse(romanNumber); 



// switch statement 
// switch(n)
// {
//     case 1: result = "i";
//     break;
//     case 2: result = "ii";
//     break;

// }
// Console.WriteLine(result);



// // See https://aka.ms/new-console-template for more information
// //Console.WriteLine("Hello, World!");

// //string PersonName = "bishnu";

// //camel casing: personheight, personHeight
// // pascal casing: PersonHeight

// // Numbers
// // Integral type
// //byte a = 255;
// //short b = 32000;
// //int c = 100000000;
// //long d = 10000000000000000;

// // floating point (with decimal points)
// //float e = 1231.123f;
// //double f = 123456.12345;
// //decimal g = 1000000.021522152m;

// //char h = 'M';
// //string i = "saksham shrestha";
// //bool j = true;
// //DateTime x = DateTime.Now;
// //Console.WriteLine(x);



// //string employee_Name = "Sakshyam shrestha";
// //byte Age =  25;
// //string Weight = "75kg";
// //bool Passport = true;
// //DateTime DateOfBirth = new DateTime(2055, 05, 16);


// //Console.WriteLine(employee_Name);
// //Console.WriteLine(Age);
// //Console.WriteLine(Weight);
// //Console.WriteLine(Passport);
// //Console.WriteLine(DateOfBirth);
// //Console.WriteLine(employee_Name, Age, Weight, Passport, DateOfBirth);


// People person1 = new();
// person1.age = 20;
// person1.name = "mike";
// string message = person1.GetLegalGreeting();
// Console.WriteLine(message);
// Console.WriteLine(person1.name);
// People person2 = new();
// person2.name = "tyson";
// person2.Weight = 50;
// string output = person2.GetOutput();
// Console.WriteLine(output);
// Console.WriteLine(person2.name);

// public string name;
//     public byte age;
//     public int Weight;


//     public string GetLegalGreeting()
//     {
//         if (age < 18)
//         {
//             return "you are underage my boy";
//         }

//         if (age ==  20)
//         {
//             return"your are ready man!";
//         }

//         else
//         {
//             return "you are notokay!";
//         }
//     }