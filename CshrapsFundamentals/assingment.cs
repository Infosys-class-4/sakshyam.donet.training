byte age1 = 23;
byte age2 = 49;
// byte age1 = 23;  
// byte age2 = 49;

// 1000
byte[] ages = new byte[1000];
46
csharpfundamentals / 1E.Methods.cs
@@ -70,41 + 70,45 @@ public float CalculateAverage(short n1, short n2, short n3, short n4)



       return average;
return average;
    }



// cw2: modify above method to take array of numbers and calculate average of all.
    
    // cw2: modify above method to take array of numbers and calculate average of all.

    public float CalculateAverageArray(params short[] numbers)
{
    float average2 = 0;

    foreach (var n in numbers)
    {
        average2 = average2 + n;
    }
    foreach (var n in numbers)
    {
        average2 = average2 + n;
    }

    float average1 = average2 / numbers.Length;
    return average1;
    float average1 = average2 / numbers.Length;
    return average1;
}

// modify same method to return average and minimum of all.
public float CalculateAverageAndMinimum(params short[] numbers)
{
    float average3 = 0;
    // modify same method to return average and minimum of all.
    // public float CalculateAverageAndMinimum(params short[] numbers)
    //     {
    //         float average3 = 0;

    foreach (var n in numbers)
    {
        average3 = average3 + n;
    }
    //     foreach (var n in numbers)
    //     {
    //         average3 = average3 + n;
    //     }

    float average = average3 / numbers.Length;
    return average;
}
//     float average = average3/numbers.Length;
//     return average;

//     float min = float.maxvalue



// }

float min = float.maxvalue



 27  
csharpfundamentals/1EMathmatics.cs
@@ -0,0 +1,27 @@
// Think of a class inside new file that can contain following members:
// Create 2 fields
// Create a method having two parameters and returns something
// Add a new expression bodied method
// Add a method whichf returns two values at a time

using System;
class Mathmatics
{

    int a = 55;
    string b = "64";

    public int Add(int a, int b) => a + b;

    public (int, string)










}
68
csharpfundamentals / Program.cs
@@ -5,36 + 5,44 @@ class program
{
    public static void Main()
    {
        Conditional_Statement a = new();
        a.ifelse();

        looping_statement b = new();
        b.AboutLoops();

        variable c = new();
        c.AboutVariable();

        Arrays d = new();
        d.LearnArrays();

        Methods m = new();
        m.print();
        m.PrintSomething("I am at another method");
        var SUM = m.Add(3434.43, 45343.34, 34343.343);
        var sum1 = m.Add(34.34, 33.343);
        var p1 = m.Multiply(5, 6, 7, 8);
        var p2 = m.Multiply(5, 6, 7, 8, 9);
        Console.WriteLine($"sum1= {SUM} sum2= {sum1} product1={p1} product2={p2}");
        byte[] numbers = { 34, 56, 12, 33, 89, 65, 21, 90 };
        var (minimum, maximum) = m.GetMinMax(numbers);

        var av = m.CalculateAverage(34, 2, 5, 7);
        Console.WriteLine(av);
        short[] nums = { 34, 45, 56, 56, 34, 34, 34 };
        var av2 = m.CalculateAverageArray();
        Console.WriteLine(av2);


        // Conditional_Statement a = new();
        // a.ifelse();

        // looping_statement b = new();
        // b.AboutLoops();

        // variable c = new();
        // c.AboutVariable();

        // Arrays d = new();
        // d.LearnArrays();

        // Methods m = new();
        // m.print();
        // m.PrintSomething("I am at another method");
        // var SUM = m.Add(3434.43, 45343.34, 34343.343);
        // var sum1 = m.Add(34.34, 33.343);
        // var p1 = m.Multiply(5, 6, 7, 8);
        // var p2 = m.Multiply(5, 6, 7, 8, 9);
        // Console.WriteLine($"sum1= {SUM} sum2= {sum1} product1={p1} product2={p2}");
        // byte[] numbers = { 34, 56, 12, 33, 89, 65, 21, 90 };
        // var (minimum, maximum) = m.GetMinMax(numbers);

        // var av = m.CalculateAverage(34, 2, 5, 7);
        // Console.WriteLine(av);
        // short[] nums = { 34, 45, 56, 56, 34, 34, 34 };
        // var av2 = m.CalculateAverageArray();
        // Console.WriteLine(av2);

        Mathmatics obj = new();
        var output = obj.Add(5, 6);
        Console.WriteLine(output);






    }