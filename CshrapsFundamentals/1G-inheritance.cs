using System;
class Mansion : House  //Single Inheritance
{   

    public Mansion()
    {

    }

    public Mansion(short nf, short nr) : base(nf,nr)
    {

    }


    float swimmingPoolArea;
    float numberofHelipads;
    void CallServant()
    {
        Console.WriteLine("need to clean swimming pool water, please come");
    }

class Palace : Mansion // Multi-level inheritance
{
    short numberOfRoyalGuards;
    
}
    class A
    {
        public virtual void sleep()
        {

        }

        public virtual void Sleep(int x, float r)
        {
            
        }
    }
 
   public interface IB
    {
       
       public  void start()
       {

       }
       public void stop()
       {

       }

        
    }

    class C : IB
    {

    }

    class D : A, IB  //  Multiple inheritance
    {
        public void start()
        {
             
        }

    }



} 
 

