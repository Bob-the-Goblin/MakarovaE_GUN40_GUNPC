using System;
using System.Windows.Markup;


public class Unit
{
    public string Name { get; }

    private float health;
    public float Health => health;
    private int damage;
    public Interval values;
    
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
    public Unit(string name, int min, int max)
    { 
        Name = name;
        values = new Interval(min, max);
        
    }
    public float RealHealth()
    {
        return Health * (1f + Armor);
    }
    public bool SetDamage( float value)
    {health -= value * Armor;

        return Health <= 0f;
    }
}
