using System;
using LivingThings;

class EntryPoint
{
    public static void Main()
    {
        // Refactoring

        // Arrays a = new();
        // a.LearnArrays();

        // Loop l = new();
        // l.LearnLoops();

        // Conditional c = new();
        // c.LearnConditionals();

        Methods m = new();
        m.Print();
        m.Print("I am yet another method");
        var s = m.Add(45.67, 67.89, 12.4);
        var s1 = m.Add(45.67, 67.89);
        var s2 = m.AddNumbers(45.67, 67.89);

        var p1 = m.Multiply(5, 6, 7, 8);
        var p2 = m.Multiply(5, 6, 7, 8, 10, 45, 23, 45);

        Console.WriteLine($"Sum1={s} Sum2={s1} Product1={p1} Product2={p2}");

        byte[] numbers = { 34, 56, 12, 33, 89, 65, 21, 90 };
        var (minimum, maximum) = m.GetMinMax(numbers);
        
        var av = m.CalculateAverage(3,4,5,6);
        Console.WriteLine($"Average1={av}");

        float[] nums = { 34.5f, 56, 12, 33, 89, 65, 21, 90, 40, 23 };
        av = m.CalculateAverage(nums);
        Console.WriteLine($"Average2={av}");

        var (average, min) = m.CalculateAverageAndMinimum(34, 56, 12, 33, 89, 65, 21, 90, 40, 23, 2, 10, -1);
        Console.WriteLine($"Average3={average}, Minimum={min}");
    
        var puppy = new Animal("dog", 4);
        var meow = new Animal();
        
        //puppy.category = "dog";
        var x = puppy.category;
        var l = puppy.numberOfLegs;


        Employee emp = new();
        emp.Name = "Bishnu";
        emp.Name = "Ba";
        emp.Name = "Bla";
        emp.Name = "B";

        var y = emp.Salary;

        var t = emp.Name;

        
        House house1 = new House(4,40);
        house1.Length = 34.4f;
        house1.Width = 25.33f;
       var chatAreaHouse1 = house1.GetAreaofChat();


        House house2 = new House(5,50,30.22f,40.22f);
        var chatAreaHouse2 = house2.GetAreaofChat();

        House house3 = new House(6,60);
        House house4 = new House(7,20);

        //IB d1 = new D();
        //d1.Start();



        collection call = new collection();
        call.learnlist();


        

        collection get = new collection();
        get.LearnDictionary();

    }
}