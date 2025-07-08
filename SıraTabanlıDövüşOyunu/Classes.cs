using System.Collections;

namespace BaseClasses;

public class Entity //Parent class  
{
    public int Health { get; set; } = 0;
    public int AttackPower { get; set; } = 0;
    public int DefensePower { get; set; } = 0;

    public string Name { get; set; }

    private static readonly Random random = new Random(); //Random Method from base Random CLass from C#  

    public Entity(int health, int attackPower, int defensePower, string name) //Constructor for polymorphism  
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
    public int TakeDamage() //For damage mechanic
    {
        int Dice = random.Next(1, 7);
        int damage = Dice * AttackPower;
        return DefensePower -= damage;
    }
} 
public class Player : Entity //Child Class for Player
{
    int PlayerHealth = 100;
    int PlayerAttackPower = 5;
    int PlayerDefencePower = 3;
    string PlayerName = "Gerald";

    public Player(int health, int attackPower, int defensePower, string name) : base(health, attackPower, defensePower, name)
    {
    }
}

public class Enemy : Entity //Child Class for Enemy
{
    int EnemyHealth = 100;
    int EnemyAttackPower = 5;
    int EnemyDefencePower = 3;
    string EnemyName = "Org";

    public Enemy(int health, int attackPower, int defensePower, string name) : base(health, attackPower, defensePower, name)
    {
    }
}