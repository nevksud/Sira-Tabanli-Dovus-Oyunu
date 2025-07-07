namespace BaseClasses;

public class Entity //Parent class

{
    public int Health { get; set; } = 0;
    public int AttackPower { get; set; } = 0;
    public int DefensePower { get; set; } = 0;

    public string Name { get; set; }

    public Entity(int health, int attackPower, int defensePower, string name)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
        DefensePower = defensePower;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
    public int TakeDamage()
    {
        return DefensePower -= AttackPower;
    }
}
 
