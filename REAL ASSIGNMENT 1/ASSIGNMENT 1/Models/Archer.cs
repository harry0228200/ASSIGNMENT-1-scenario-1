using System;

namespace ASSIGNMENT_1.Models
{
    public class Archer : Character
    {
        public Archer(int id, string name, int health, int attackPower, int defense)
            : base(id, name, health, attackPower, defense)
        {
        }

        public override void specialAbility(Character target)
        {
            int damage = AttackPower + 10;
            target.Health -= damage;
            Console.WriteLine($"{Name} uses Precision Shot on {target.Name} for {damage} damage!");
        }
    
    }
}
