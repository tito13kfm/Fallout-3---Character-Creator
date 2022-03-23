using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fallout_3___Character_Creator
{
    internal class Program
    {
        static List<Character> characters = new List<Character>();
        static int j;

        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Create a Character");
                if (characters.Count > 0)
                {
                    Console.WriteLine("2. Change Skills");
                }
                if (characters.Count > 0)
                {
                    Console.WriteLine("3. Print a Character");
                }
                Console.Write("Make choice: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Character name: ");
                        string name = Console.ReadLine();
                        Character index = new Character();
                        {
                            index.Name = name;
                            index.Strength = 5; index.Perception = 5; index.Endurance = 5; index.Charisma = 5;
                            index.Intelligence = 5; index.Agility = 5; index.Luck = 5; index.StatPoints = 5;
                            index.Barter = 15; index.BigGuns = 15; index.EnergyWeapons = 15; index.Explosives = 15;
                            index.Lockpick = 15; index.Medicine = 15; index.MeleeWeapons = 15; index.Repair = 15;
                            index.Science = 15; index.SmallGuns = 15; index.Sneak = 15; index.Speech = 15; index.Unarmed = 15;
                        }
                        characters.Add(index);
                        Console.WriteLine(String.Format("Character {0} created successfully", index.Name));
                        Console.ReadLine();
                        break;
                    case "2":
                        SelectCharacter();
                        EditCharacter();
                        break;
                    case "3":
                        SelectCharacter();
                        PrintCharacter(j);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void EditCharacter()
        {
            throw new NotImplementedException();
        }

        private static void PrintCharacter(int j)
        {
            Console.Clear();
            Console.WriteLine(characters[j].Name);
            Console.WriteLine("   S.P.E.C.I.A.L   ");
            Console.WriteLine("Strength:         " + characters[j].Strength);
            Console.WriteLine("Perception:       " + characters[j].Perception);
            Console.WriteLine("Endurance:        " + characters[j].Endurance);
            Console.WriteLine("Charisma:         " + characters[j].Charisma);
            Console.WriteLine("Intelligence:     " + characters[j].Intelligence);
            Console.WriteLine("Agility:          " + characters[j].Agility);
            Console.WriteLine("Luck:             " + characters[j].Luck);


            Console.ReadLine();
            return;
        }

        static int SelectCharacter()
        {
            int i = 1;
            foreach (Character c in characters)
            {
                Console.WriteLine(i.ToString() + ") " + c.Name);
                i++;
            }
            Console.Write("Choose which character to print: ");
            j = Int32.Parse(Console.ReadLine()) -1;
            return j;
          
        }
    }
}
