using System;

namespace ASSIGNMENT_1.Models
{
    public abstract class Character
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; } 


        public Character(int id, string name, int health, int attackPower, int defense)
        {
            Id = id;
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
        }


        public abstract void specialAbility(Character target);

        public virtual void Attack(Character target)
        {
            int damage = AttackPower - target.Defense;
            if (damage < 0) damage = 0;
            
            target.Health -= damage;
            Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
        } 


        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Health: {Health}, Attack Power: {AttackPower}, Defense: {Defense}");
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}
