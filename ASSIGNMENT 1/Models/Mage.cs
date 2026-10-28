using System;

namespace ASSIGNMENT_1.Models
{
    public class Mage : Character
    {
        public Mage(int id, string name, int health, int attackPower, int defense)
            : base(id, name, health, attackPower, defense)
        {
        }

        public override void specialAbility(Character target)
        {
            int damage = AttackPower + 20;
            target.Health -= damage;
            Console.WriteLine($"{Name} uses Fireball on {target.Name} for {damage} damage!");
        }
    }
}
