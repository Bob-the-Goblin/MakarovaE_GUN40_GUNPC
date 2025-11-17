using System;
using System.Runtime.InteropServices.Marshalling;
using System.Windows.Markup;

public class Unit
{
    public string Name { get; }

    private float health;
    public float Health => health;
    private int damage;
    public Interval values = new Interval(0, 5);
    
    private float armor;
    public float Armor => armor;

    public Unit() : this(name: "Unknow unit")
    {
        
        armor = 0.6f;
    }
    public Unit(string name)
    {
        Name = name;
        armor = 0.6f;
    }
    public float RealHealth()
    {
        return Health * (1f + Armor);
    }
    public bool SetDamage( float value)
    {health -= values.Max * Armor;

        if (Health <= 0f)
        {
            return true;
        }
        else return false;
    }
}

public class Weapon
{
    public string Name { get; }
    public Interval values {  get; }
    public float Durability { get; }

    public Weapon(string name)
    { Name = name; }
    public Weapon(string name, int minDamage, int maxDamage) : this(name)
    {
        Name = name;
        values = new Interval(minDamage, maxDamage);
        SetDamageParams( values.Min, values.Max);
    }
    public void SetDamageParams(int minDamage, int maxDamage)
    {
        if (minDamage < 1)
        {
            minDamage = 1;
            Console.WriteLine("Forsed instalation for minDamage value");
        }
        if (maxDamage <= 1)
        {
            maxDamage = 10;
        }
        if (minDamage > maxDamage)
        {
            int forReplace = minDamage;
            minDamage = maxDamage;
            maxDamage = forReplace;
            Console.WriteLine($"Incorrect input; Weapon - {Name}");
        }
    }
    public int GetDamage()
    {
        return (values.Min + values.Max ) / 2;
    }
}