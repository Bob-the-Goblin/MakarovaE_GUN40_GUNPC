using System;

    public class Weapon
    {
        public string Name { get; }
        public Interval values { get; set; }
        public float Durability { get; }

        public Weapon(string name)
        { Name = name; }
        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            Name = name;
       
    
        }
        public void SetDamageParams(int minDamage, int maxDamage)
        {
        values = new Interval(minDamage, maxDamage);
        }
        public int GetDamage()
        {
            return (values.Min + values.Max) / 2;
        }
    }

