// c# is objecrt-oriented language

// programming paradime
// Procedural: c, PASCAL, BASIC, GO
// Imperative: Go, c#, c, c++
// Declarative: python
// Object Oriented: C#, java, python
// Functional: F#, Scale, Haskell
// Dyanamic: JS, Ruby, Python
// Static: C#,java

// c# is multiple-paradigm language


//class People
//{
// public string name;
//public byte age;


// public string GetLegalGreeting()
//  {
//   if (age < 18)
// {
//   return "you are underage my boy";
//}
//else
// {
//   return "you are okay!";
//}
//}
//}

class bikes
{
    public string model;
    public string color;
    public int year;

    static void Main(string[] args)

    {
        bikes kawasaki = new bikes();
        kawasaki.model = "kawasaki";
        kawasaki.color = "red";
        kawasaki.year = 1969;

        bikes honda = new bikes();
        honda.model = "honda";
        honda.color = "white";
        honda.year = 2005;


        bikes bajaj = new bikes();
        bajaj.model = "bajaj";
        bajaj.color = "white";
        bajaj.year = 2005;

        Console.WriteLine(kawasaki.model);
        Console.WriteLine(honda.model);
        Console.WriteLine(bajaj.model);
    }
}




