using System.Collections.Generic;
class collection
{
   public void learnlist()

    {
        List<string> nameList = new List<string>();
        nameList.Add("abc");
        nameList.Add("cde");

        List<byte> ages = new List<byte>{1, 2, 3, 4, 5};
        
      

        //cw - Define list of 10 even numbers.

        List<int> evenNumber = new List<int>{2, 4, 5, 6, 8, 10, 12, 14};
        evenNumber.Add(16);

        //List<Person> people = new List<Person>();


        // stack and queue
        Stack<string> plates = new Stack<string>();//lifo
        plates.Push("plate1");
        plates.Push("plate2");
        plates.Push("plate3");
        plates.Pop();

    foreach(var item in plates)
    {
        Console.WriteLine(item);
    }

        Queue<string> platekoLine = new Queue<string>();// fifo
        platekoLine.Enqueue("plate1");
        platekoLine.Enqueue("plate2");
        platekoLine.Enqueue("plate3");
        platekoLine.Dequeue();

        foreach(var thing in platekoLine)
        {
            Console.WriteLine(thing);
        }

    }
public void LearnDictionary() 
{
    Dictionary<string, string> countryCapital = new();
    countryCapital.Add("nepal","kathmandu");
    countryCapital.Add("india","newdelhi");
    countryCapital.Add("china","beijing");

    foreach(var item in countryCapital)
    {
        Console.WriteLine($"{item.Key} -> {item.Value}");
    }


    Dictionary<string, int> countryPopulation = new();
    countryPopulation.Add("nepal",39238400);
    countryPopulation.Add("india",1234567000);
    Console.WriteLine("country\t\tpopulation");
    Console.WriteLine("........................");

    foreach( var item in countryPopulation)
    {
        Console.WriteLine($"{item.Key} \t->\t {item.Value}");
    }

}
}


//cw - Define a ictionary to hold the population of any country...

 


