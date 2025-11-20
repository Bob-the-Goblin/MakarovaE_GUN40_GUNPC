using System;

public class Room
    {   
     public Unit Hero { get; }
     public Weapon Sword { get; }

     public Room(Unit hero, global::Weapon sword)
    {
     this.Hero = hero;
     this.Sword = sword;
    }

    }

