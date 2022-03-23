using System;
using System.Collections.Generic;

namespace Fallout_3___Character_Creator
{
    internal class Program
    {
        static List<Character> characters = new List<Character>();
        static int j;
        static int amount=0;

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
                int stat;
                int changeAmount;
                switch (selection)
                {
                    case "S":
                        statSelected = "Strength";
                        stat = characters[j].Strength;
                        ModifyStat(stat, statSelected);
                        changeAmount = amount - characters[j].Strength;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Strength = amount;                   
                        break;
                    case "P":
                        statSelected = "Perception";
                        stat = characters[j].Perception;
                        ModifyStat(stat, statSelected);
                        changeAmount = amount - characters[j].Perception;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Perception = amount;
                        break;
                    case "E":
                        statSelected = "Endurance";
                        stat = characters[j].Endurance;
                        ModifyStat(stat, statSelected);
                        changeAmount = amount - characters[j].Endurance;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Endurance = amount;
                        break;
                    case "C":
                        statSelected = "Charisma";
                        stat = characters[j].Charisma;
                        ModifyStat(stat, statSelected);
                        changeAmount = amount - characters[j].Charisma;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Charisma = amount;
                        break;
                    case "I":
                        statSelected = "Intelligence";
                        stat = characters[j].Intelligence;
                        ModifyStat(stat, statSelected);
                        changeAmount = amount - characters[j].Intelligence;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Intelligence = amount;
                        break;
                    case "A":
                        statSelected = "Agility";
                        stat = characters[j].Agility;
                        ModifyStat(stat, statSelected);
                        changeAmount = amount - characters[j].Agility;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Agility = amount;
                        break;
                    case "L":
                        statSelected = "Luck";
                        stat = characters[j].Luck;
                        ModifyStat(stat, statSelected);
                        changeAmount = amount - characters[j].Luck;
                        characters[j].StatPoints = characters[j].StatPoints - changeAmount;
                        characters[j].Luck = amount;
                        break;
                    case "Q":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Enter a valid selection");
                        Console.WriteLine("Press any key to continue");
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
                amount = Int32.Parse(Console.ReadLine());
                if ((amount - stat) <= characters[j].StatPoints)
                {
                    valid = true;
                }
            }
            return amount;
        }

        private static void PrintCharacter(int j)
        {
            Console.Clear();
            Console.WriteLine(characters[j].Name);
            Console.WriteLine("   S.P.E.C.I.A.L   ");
            Console.WriteLine("-------------------");
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
            return j;

        }
    }
}
