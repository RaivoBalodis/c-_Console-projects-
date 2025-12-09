using System;

namespace DnD
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to DnD");

            Console.Write("Your Name:  ");
            string name = Console.ReadLine();

            //data
            int hp = 20;
            int enemyhp = 15;
            Random r = new Random();

            Console.WriteLine($"Weclcome {name}. You have {hp} HP. good luck!");
            Console.WriteLine("An evil goblin appears!");

            while(hp > 0 && enemyhp > 0)
            {
                Console.WriteLine("\nChoose: 1)attack 2)heal 3)run");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    int dmd = r.Next(3,8);
                    Console.WriteLine($"You bonk goblin for {dmd} damage");
                    enemyhp -= dmd;
                }
                else if (choice == "2")
                {
                    int heal = r.Next(4,10);
                    Console.WriteLine($"You heal {heal} HP!");
                    hp += heal;
                    if(hp > 20) hp = 20;
                }

                else if (choice == "3")
                {
                    Console.WriteLine("You run like a chicken!");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid");
                    continue;
                }
                if (enemyhp > 0)
                {
                    int enemydmd = r.Next(10,20);
                    Console.WriteLine($"Goblin hit you for {enemydmd} damage");
                    hp -= enemydmd;
                }

                Console.WriteLine($"Your HP: {hp}, Goblin HP: {enemyhp} ");
            }

            if (hp <= 0)
            {
                Console.WriteLine("you died");
            }
            else
            {
                Console.WriteLine("You killed the goblin");
            }
        }
    }
}