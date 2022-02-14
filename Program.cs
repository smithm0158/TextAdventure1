using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 2/13/22
 * CSC 153 
 * Michael Smith
 * Basic Menu for game
 */

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] rooms = new string[] { "Entrance", "Hallway", "Bridge", "Engine Room", "Medbay" };
            string[] weapons = new string[] { "Pipe", "Laser Pistol", "Knife", "Laser Rifle" };
            string[] potions = new string[] { "Potion of Intelligece", "Potion of Damage" };
            string[] treasures = new string[] { "Etherium", "Jet Fuel", "Crystallized Data" };
            string[] items = new string[] { "Keykard", "Fuel Canister", "Monitor", "Engine" };
            string[] mobs = new string[] { "Alien", "Tormented Alien", "Corrupted Human", "Zombie" };

            List<string> itemsList = new List<string>();
            List<string> mobsList = new List<string>();


            bool exit = false;

            //Main menu

            while (exit == false)
            {

                Console.WriteLine("Choose a number from the list below: ");
                Console.WriteLine("1. Display Rooms");
                Console.WriteLine("2. Display Weapons");
                Console.WriteLine("3. Display Potions");
                Console.WriteLine("4. Display Treasure");
                Console.WriteLine("5. Display Items");
                Console.WriteLine("6. Display Mobs");
                Console.WriteLine("7. Exit");
                Console.Write("Enter a choice > ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine();
                    foreach (string room in rooms)
                    { Console.WriteLine(room); }
                    Console.WriteLine();

                }
                
                else if (input == "2") 
                {
                    Console.WriteLine();

                    Array.Sort(weapons);
                    foreach (string weapon in weapons) ;
                    Console.WriteLine(weapons);
                    Console.WriteLine();
                }
                else if (input == "3")
                {
                    Console.WriteLine();
                    foreach (string potion in potions)
                    { Console.WriteLine(potion); }
                    Console.WriteLine();
                }
                else if (input == "4")
                {
                    Console.WriteLine();
                    foreach (string treasure in treasures)
                    { Console.WriteLine(treasure); }
                    Console.WriteLine();
                }
                else if (input == "5")
                {
                    Console.WriteLine();
                    foreach (string item in itemsList)
                    { Console.WriteLine(item); }
                    Console.WriteLine();
                }
                else if (input == "6")
                {
                    Console.WriteLine();
                    foreach (string mob in mobsList)
                    { Console.WriteLine(mob); }
                    Console.WriteLine();
                }
                else if (input == "7")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a choice!");
                }
            }


        }
    }
}
