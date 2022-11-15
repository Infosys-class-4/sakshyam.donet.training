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


class People
{
    public string name;
    public byte age;
    public int Weight;


    public string GetLegalGreeting()
    {
        if (age < 18)
        {
            return "you are underage my boy";
        }
        
        if (age ==  20)
        {
            return"your are ready man!";
        }

        else
        {
            return "you are notokay!";
        }

        
    }
    public string GetOutput()
    {
          if (Weight < 20)
        {
            return"your are not ready my boy";
        }

        else
        {
            return "your weight is good";
        }

    }
}
