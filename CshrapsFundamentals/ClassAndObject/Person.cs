class House 
{
    bool haveGarage;
    short numberofFloors;
    short numberofRooms;
    public float Length{get; set;}
    public float Width{get; set;}




    public House()
    {

    }

public House(short noF,short noR)
{
         numberofFloors = noF;
         numberofFloors = noF;
}
public House(short noF,short noR,float l, float w)
{
         numberofFloors = noF;
         numberofFloors = noF;
         Length = l;
         Width = w;

}



//methods
    public float GetAreaofChat() => Length*Width;

}