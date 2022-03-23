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
                    Console.WriteLine("3. Print a Character");
                    Console.WriteLine("4. Delete a Character");
                }
                Console.Write("Make choice: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreateCharacter();
                        break;
                    case "2":
                        SelectCharacter();
                        EditCharacter(j);
                        break;
                    case "3":
                        SelectCharacter();
                        PrintCharacter(j);
                        break;
                    case "4":
                        SelectCharacter();
                        DeleteCharacter(j);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void DeleteCharacter(int j)
        {
            string delete="";
            Console.Clear();
            Console.WriteLine("Are you sure you want to delete {0}?",characters[j].Name);
            Console.WriteLine("This action is permanent!");
            Console.WriteLine("Enter DELETE below to delete {0}", characters[j].Name);
            delete = Console.ReadLine();
            switch (delete)
            {
                case "DELETE":
                    characters.Remove(characters[j]);
                    break;
                default:
                    break;
            }
        }

        private static void CreateCharacter()
        {
            Console.WriteLine("Character name: ");
            string name = Console.ReadLine();
            Character index = new Character();
            {
                index.Name = name;
            }
            characters.Add(index);
            Console.WriteLine(String.Format("Character {0} created successfully", index.Name));
            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();
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
            Console.WriteLine("{0,-5}{1,16}","Name", characters[j].Name);
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}    {4,-20}{5,-2}", "    S.P.E.C.I.A.L", "", "", "", "         SKILLS","");
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}    {4,-20}{5,-2}", "---------------------", "", "", "", "----------------------", "");
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}     {4,-20}{5,-2}", "Strength:",characters[j].Strength,"Action Points", characters[j].Agility + 65,"Barter",characters[j].Barter);
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}     {4,-20}{5,-2}", "Perception:", characters[j].Perception,"Carry Weight", characters[j].Strength*10 + 150,"Big Guns",characters[j].BigGuns);
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}     {4,-20}{5,-2}", "Endurance:" , characters[j].Endurance, "Critical Chance", characters[j].Luck +"%", "Energy Weapons", characters[j].EnergyWeapons);
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}     {4,-20}{5,-2}", "Charisma:" , characters[j].Charisma, "Dmg Resist", "0%", "Explosives", characters[j].Explosives);
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}     {4,-20}{5,-2}", "Intelligence:" , characters[j].Intelligence, "Hit Points", characters[j].Endurance*20 + 100, "Lockpick", characters[j].Lockpick);
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}     {4,-20}{5,-2}", "Agility:" , characters[j].Agility, "Melee Damage", characters[j].Strength*.5, "Medicine", characters[j].Medicine);
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}     {4,-20}{5,-2}", "Luck:" , characters[j].Luck, "Skill Points", characters[j].Intelligence + 10, "Melee Weapons", characters[j].MeleeWeapons);
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}     {4,-20}{5,-2}", "", "","","", "Repair", characters[j].Repair);
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}     {4,-20}{5,-2}", "", "","","", "Science", characters[j].Science);
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}     {4,-20}{5,-2}", "", "","","", "Small Guns", characters[j].SmallGuns);
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}     {4,-20}{5,-2}", "", "","","", "Sneak", characters[j].Sneak);
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}     {4,-20}{5,-2}", "", "","","", "Speech", characters[j].Speech);
            Console.WriteLine("{0,-20}{1,-2}     {2,-20}{3,-3}     {4,-20}{5,-2}", "", "","","", "Unarmed", characters[j].Unarmed);

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
