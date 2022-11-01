public class Human
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Health { get; set; }

    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    public Human(string name, int str, int intel, int dex, int health)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = health;
    }
    public virtual int Attack(Human target)
    {
        int dmg = 3 * Strength;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name}. {target.Name}'s health is now {target.Health}");
        return target.Health;
    }
}

