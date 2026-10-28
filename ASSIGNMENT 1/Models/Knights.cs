using System;

namespace ASSIGNMENT_1.Models
{
    public class Knight : Character
    {
        public Knight(int id, string name, int health, int attackPower, int defense)
            : base(id, name, health, attackPower, defense)
        {
        }

        public override void specialAbility(Character target)
        {
            int damage = AttackPower + 15;
            target.Health -= damage;
            Console.WriteLine($"{Name} uses Shield Bash on {target.Name} for {damage} damage!");
        }
    }
}
