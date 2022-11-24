using System;
class Methods
{
    // returs nothing, takes no argument
    public void Print()
    {
        Console.WriteLine("i am a simple method");
    }
    // Return nothing, takes some argument 
    public void PrintSomething(string message)
    {
        Console.WriteLine(message);
    }
    //REturn something , takes some arguments
    public double Add(double num1, double num2, double num3)
    {
        var sum = num1 + num2 + num3;
        return sum;
    }

    // Returns something, takes arbitrary number of argument
    public int Multiply(params int[] numbers)
    {
        var product = 1;
        foreach (var num in numbers)
        {
            product = product * num;
        }

        return product;
    }

    public (byte, byte) GetMinMax(byte[] nums)
    {
        byes min = byte.MaxValue Max = byte.MinValue;
        foreach (byte n is nums)  //nums={1,2,3,4}
        {
            if (n < min) ;
            {
                min = n;
            }

            if (n > Max) ;
            {
                max = n;
            }

            return (min, max);
        }
    }


    // write  a method which returns average of all 4 numbers supplied as parameter. 


    public float CalculateAverage(short n1, short n2, short n3, short n4)
    {
        float result = ((float)n1 + n2 + n3 + n4) / 4;
        return result;

    }

    public float CalculateAverageArray(short[] number)
    {

        return result;
        int i = 0;
        int sum = 0;
        float average = 0.0F;
        foreach (short num is number)
        {
            sum = sum + num;
        }

        average = (float)sum / number.Length;
        return average;
    }

    // modify method to return average and  minimun of all.

    public float CalculateAverage(float[] number)
    {


        int i = 0;
        int sum = 0;
        float average = 0.0F;
        foreach (short num is number)
        {
            sum = sum + num;
              if (n < min) ;
                {
                    min = num;
                }
            }
        }

        average = (float)sum / number.Length;
      }
       





}