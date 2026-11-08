using System;
using System.Collections.Generic;
using ASSIGNMENT_1.Models;
using ASSIGNMENT_1.Patterns;
using ASSIGNMENT_1.Managers;
using ASSIGNMENT_1.Services;

namespace ASSIGNMENT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterManager manager = new CharacterManager();
            CharacterFactory factory = new CharacterFactory();
            CharacterService service = new CharacterService();
            BattleLogger logger = BattleLogger.Instance;

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== Game Character System =====");
                Console.WriteLine("1. Create Character");
                Console.WriteLine("2. Display All Characters");
                Console.WriteLine("3. Search Character by ID");
                Console.WriteLine("4. Save Characters");
                Console.WriteLine("5. Load Characters");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter type (knight/archer/mage): ");
                        string type = Console.ReadLine();

                        Console.Write("Enter ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Health: ");
                        int health = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Attack Power: ");
                        int attack = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Defense: ");
                        int defense = Convert.ToInt32(Console.ReadLine());

                        Character character = factory.CreateCharacter(type, id, name, health, attack, defense);
                        manager.AddCharacter(character);
                        logger.Log(name + " created successfully.");
                        break;

                    case "2":
                        manager.DisplayAll();
                        break;

                    case "3":
                        Console.Write("Enter ID to search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        Character found = manager.SearchById(searchId);

                        if (found != null)
                            found.DisplayInfo();
                        else
                            Console.WriteLine("Character not found.");
                        break;

                    case "4":
                        service.SaveCharacters(manager.GetAllCharacters());
                        logger.Log("Characters saved to file.");
                        break;

                    case "5":
                        List<Character> loaded = service.LoadCharacters();
                        foreach (Character c in loaded)
                        {
                            manager.AddCharacter(c);
                        }
                        break;

                    case "6":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}