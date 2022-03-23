using System;
using System.Collections.Generic;

namespace Fallout_3___Character_Creator
{
    internal class Program
    {
        static List<Character> characters = new List<Character>();
        static int j;
        static int newStatValue=0;

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
                        EditCharacter(j);
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

        private static void EditCharacter(int j)
        {
            bool quit = false;
            Console.Clear();
            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("You have " + characters[j].StatPoints + " Stat Points remaining");
                Console.WriteLine("Edit which stat for " + characters[j].Name + " Q to quit");
                Console.Write("S.P.E.C.I.A.L :");
                string selection = Console.ReadLine().ToUpper();
                string statSelected="";
                int statValue;
                int changeAmount;
                switch (selection)
                {
                    case "S":
                        statSelected = "Strength";
                        statValue = characters[j].Strength;
                        ModifyStat(statValue, statSelected);
                        changeAmount = newStatValue - characters[j].Strength;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Strength = newStatValue;                   
                        break;
                    case "P":
                        statSelected = "Perception";
                        statValue = characters[j].Perception;
                        ModifyStat(statValue, statSelected);
                        changeAmount = newStatValue - characters[j].Perception;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Perception = newStatValue;
                        break;
                    case "E":
                        statSelected = "Endurance";
                        statValue = characters[j].Endurance;
                        ModifyStat(statValue, statSelected);
                        changeAmount = newStatValue - characters[j].Endurance;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Endurance = newStatValue;
                        break;
                    case "C":
                        statSelected = "Charisma";
                        statValue = characters[j].Charisma;
                        ModifyStat(statValue, statSelected);
                        changeAmount = newStatValue - characters[j].Charisma;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Charisma = newStatValue;
                        break;
                    case "I":
                        statSelected = "Intelligence";
                        statValue = characters[j].Intelligence;
                        ModifyStat(statValue, statSelected);
                        changeAmount = newStatValue - characters[j].Intelligence;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Intelligence = newStatValue;
                        break;
                    case "A":
                        statSelected = "Agility";
                        statValue = characters[j].Agility;
                        ModifyStat(statValue, statSelected);
                        changeAmount = newStatValue - characters[j].Agility;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Agility = newStatValue;
                        break;
                    case "L":
                        statSelected = "Luck";
                        statValue = characters[j].Luck;
                        ModifyStat(statValue, statSelected);
                        changeAmount = newStatValue - characters[j].Luck;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Luck = newStatValue;
                        break;
                    case "Q":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Enter a valid selection");
                        Console.WriteLine("Press Enter to continue");
                        break;
                }
            }
        }

        private static int ModifyStat(int stat, string statSelected)
        {
            bool valid = false;
            while (!valid)
            {
                Console.Clear();
                Console.WriteLine("Current " + statSelected + " is " + stat);
                Console.WriteLine(characters[j].StatPoints + " remaining");
                Console.Write("Enter new " + statSelected + ": ");
                newStatValue = Int32.Parse(Console.ReadLine());
                if ((newStatValue - stat) <= characters[j].StatPoints)
                {
                    valid = true;
                }
            }
            return newStatValue;
        }

        private static void PrintCharacter(int j)
        {
            Console.Clear();
            Console.WriteLine("Name: {0,15}", characters[j].Name);
            Console.WriteLine("   S.P.E.C.I.A.L   ");
            Console.WriteLine("---------------------");
            Console.WriteLine("Strength:           " + characters[j].Strength);
            Console.WriteLine("Perception:         " + characters[j].Perception);
            Console.WriteLine("Endurance:          " + characters[j].Endurance);
            Console.WriteLine("Charisma:           " + characters[j].Charisma);
            Console.WriteLine("Intelligence:       " + characters[j].Intelligence);
            Console.WriteLine("Agility:            " + characters[j].Agility);
            Console.WriteLine("Luck:               " + characters[j].Luck);

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            return;
        }

        private static int SelectCharacter()
        {
            int i = 1;
            foreach (Character c in characters)
            {
                Console.WriteLine(i.ToString() + ") " + c.Name);
                i++;
            }
            Console.Write("Choose character: ");
            j = Int32.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Press Enter to continue");
            return j;

        }
    }
}
