using System;
using System.Runtime.InteropServices.Marshalling;

public class Unit
{
    public string Name { get; }

    private float health;
    public float Health => health;
    public int Damage { get; }
    private float armor;
    public float Armor => armor;

    public Unit() : this(name: "Unknow unit")
    {
        Damage = 5;
        armor = 0.6f;
    }
    public Unit(string name)
    {
        Name = name;
        Damage = 5;
        armor = 0.6f;
    }
    public float RealHealth()
    {
        return Health * (1f + Armor);
    }
    public bool SetDamage( float value)
    {
        if (Health <= 0f)
        {
            return true;
        }
        else return false;
        Health - value* Armor;
    }
}