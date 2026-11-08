using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ASSIGNMENT_1.Models;

namespace ASSIGNMENT_1.Services
{
    public class CharacterService
    {
        private string _filePath = "characters.json";

        // Save characters to JSON file
        public void SaveCharacters(List<Character> characters)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(characters, options);
                File.WriteAllText(_filePath, json);
                Console.WriteLine("Characters saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving characters: " + ex.Message);
            }
        }

        // Load characters from JSON file
        public List<Character> LoadCharacters()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    Console.WriteLine("No saved file found.");
                    return new List<Character>();
                }

                string json = File.ReadAllText(_filePath);
                List<Character> characters = JsonSerializer.Deserialize<List<Character>>(json);
                Console.WriteLine("Characters loaded successfully.");
                return characters;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading characters: " + ex.Message);
                return new List<Character>();
            }
        }
    }
}