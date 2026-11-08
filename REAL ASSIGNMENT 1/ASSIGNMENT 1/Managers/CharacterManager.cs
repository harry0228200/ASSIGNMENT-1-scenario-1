using System;
using System.Collections.Generic;
using ASSIGNMENT_1.Models;

namespace ASSIGNMENT_1.Managers
{
    public class CharacterManager
    {
        private List<Character> _characters = new List<Character>();

        public void AddCharacter(Character character)
        {
            _characters.Add(character);
        }

        public List<Character> GetAllCharacters()
        {
            return _characters;
        }

        public Character SearchById(int id)
        {
            foreach (Character character in _characters)
            {
                if (character.Id == id)
                {
                    return character;
                }
            }
            return null;
        }

        public Character SearchByName(string name)
        {
            foreach (Character character in _characters)
            {
                if (character.Name == name)
                {
                    return character;
                }
            }
            return null;
        }

        public void DisplayAll()
        {
            foreach (Character character in _characters)
            {
                character.DisplayInfo();
            }
        }
    }
}
