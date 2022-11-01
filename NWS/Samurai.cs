public class Samurai : Human
{
    public Samurai(string name) : base(name, 3, 3, 3, 200){}

    public override int Attack(Human target)
    {
        int dmg = Strength * 3;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name}. {target.Name}'s health is now {target.Health}");
        if(target.Health < 50)
        {
            target.Health = 0;
            Console.WriteLine($"{Name} executed {target.Name}. {target.Name}'s health is now {target.Health}");
        }
        return target.Health;
    }

    public void Meditate()
    {
        Health = 200;
        Console.WriteLine($"Health restored to {Health}");
    }
}
