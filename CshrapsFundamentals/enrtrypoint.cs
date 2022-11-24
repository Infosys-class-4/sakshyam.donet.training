using System;
class EnrtryPoint
{
    public static void Main()
    {
        Conditionals a = new();
        a.LearnConditionals();


        Methods m = new();
        m.Print();
        m.PrintSomething("i am a simple method");
        var s = m.Add(45.33, 65.55, 12.55);
        var p1 = m.Multiply(1, 2, 3, 4);
        var p2 = m.Multiply(5, 4, 3, 2, 1);
        Console.WriteLine($"sum1={s} product1={p1} product2={p2}");

        byte[] number = { 10, 10, 40, 50, 60, 70,};
        var result = m.
    }
}