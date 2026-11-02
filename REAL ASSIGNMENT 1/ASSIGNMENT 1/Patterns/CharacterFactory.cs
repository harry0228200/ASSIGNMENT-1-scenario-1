using System;
using ASSIGNMENT_1.Models;

namespace ASSIGNMENT_1.Patterns
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string type, int id, string name, int health, int attackPower, int defense)
        {
            type = type.ToLower();

            switch (type)
            {
                case "knight":
                    return new Knight(id, name, health, attackPower, defense);

                case "archer":
                    return new Archers(id, name, health, attackPower, defense);

                case "mage":
                    return new Mage(id, name, health, attackPower, defense);

                default:
                    throw new ArgumentException("Invalid character type. Use knight, archer or mage.");
            }
        }
    }
}
