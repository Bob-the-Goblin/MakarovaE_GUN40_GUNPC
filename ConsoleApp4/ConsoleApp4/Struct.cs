using System;
using System.Security.Cryptography.X509Certificates;

public struct Interval
{

    public int Min { get;  }
    public int Max { get; }
    private int get;
    public int Get { get; }


    public Interval(int min, int max)
    {
        Min = min;

        var rand = new Random();
        Get = rand.Next(Min, Max);

        if (min >  max)
        {
            int toReplace = min;
            min = max;
            max = toReplace;
        }
        if (min < 0) { min = 0; Console.WriteLine("Incorrect Input"); }
        if (max < 0) { max = 0; Console.WriteLine("Incorrect Input"); }
        if (max == min) { max += 10; Console.WriteLine("Incorrect Input"); }
    }
}

public struct Room
{
    public Unit unit;
    public Weapon weapon;


    public Room(Unit unit, Weapon weapon)
    {
        this.unit = unit;
        this.weapon = weapon;
    }
    

}


public struct Dungeon
{
    Room[] room;
    public Dungeon()
    {
        room = new Room[4]
        {
            new Room(new Unit("Biba"), new Weapon("Gun")),
            new Room(new Unit("Boba"), new Weapon("Sword")),
            new Room(new Unit("Bobi"), new Weapon("SwordGun")),
            new Room(new Unit("Bibo"), new Weapon("Guitar"))
        }; }

        public void ShowRooms()
    {
        for (int i = 0; i < room.Length; i++)
        {
        var rooms = room[i];
        Console.WriteLine("Unit of room " + rooms.unit.Name);
        Console.WriteLine("Weapon of room " + rooms.weapon.Name);
        Console.WriteLine();
        }
        
    }


}


