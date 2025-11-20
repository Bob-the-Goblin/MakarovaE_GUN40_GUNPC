using System;


public struct Dungeon
{
    Room[] rooms;
    public Dungeon()
    {
        rooms = new Room[4]
        {
            new Room(new Unit("Biba"), new global::Weapon("Gun")),
            new Room(new Unit("Boba"), new global::Weapon("Sword")),
            new Room(new Unit("Bobi"), new global::Weapon("SwordGun")),
            new Room(new Unit("Bibo"), new global::Weapon("Guitar"))
        };
    }

    public void ShowRooms()
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            var room = rooms[i];
            Console.WriteLine("Unit of room " + room.Hero.Name);
            Console.WriteLine("Weapon of room " + room.Sword.Name);
            Console.WriteLine();
        }

    }
}
