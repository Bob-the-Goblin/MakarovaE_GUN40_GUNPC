using System;

public class Weapon
{
    public string Name { get; }
    private int MinDamage;
    private int MaxDamage;
    public float Durability { get; }

    public Weapon(string name)
    { }
    public Weapon(string name, int minDamage, int maxDamage): this(name)
    {
        SetDamageParams(this.MinDamage, this.MaxDamage);
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
        if (minDamage > MaxDamage)
        {
            int forReplace = minDamage;
            MinDamage = maxDamage;
            MaxDamage = forReplace;
            Console.WriteLine($"Incorrect input; Weapon - {Name}");
        }
    }
    public int GetDamage()
    {
        return (MinDamage+MaxDamage)/2; 
    }
}