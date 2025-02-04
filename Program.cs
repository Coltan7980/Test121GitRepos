//Written by Coltan Paul
//2/4/25
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace HomeWork2
{
    /*
     internal class Problem1WatchTower
    {
        static void Main(string[] args)
        {
            string xValue = Console.ReadLine();
            string yValue = Console.ReadLine();
            Watchtower Problem1 = new Watchtower();
            Problem1.X = Convert.ToInt32(xValue);
            Problem1.Y = Convert.ToInt32(yValue);
            Console.WriteLine(Problem1.CalcDirection());
        }
        
            

        
    }
    
    internal class Problem2and3
    {
        static void Main(string[] args)
        {
            BuyingInventory Solution2 = new BuyingInventory();

            Console.WriteLine(Solution2.DisplayItems());
            string num = Console.ReadLine();
            Console.WriteLine("What's your name?: ");
            string name = Console.ReadLine();
            Solution2.Number = Convert.ToInt32(num);
            if (name != "Coltan")
            {
                switch (Solution2.Number)
                {
                    case 1:
                        Console.WriteLine("Rope costs 10 gold.");
                        break;
                    case 2:
                        Console.WriteLine("Torches cost 15 gold.");
                        break;
                    case 3:
                        Console.WriteLine("Climbing Equipment costs 25 gold.");
                        break;
                    case 4:
                        Console.WriteLine("Clean Water costs 1 gold.");
                        break;
                    case 5:
                        Console.WriteLine("Machetes cost 20 gold.");
                        break;
                    case 6:
                        Console.WriteLine("Canoes cost 200 gold.");
                        break;
                    case 7:
                        Console.WriteLine("Food Supplies costs 1 gold.");
                        break;
                }
            }
            else
            {
                switch (Solution2.Number)
                {
                    case 1:
                        Console.WriteLine("Rope costs 5 gold.");
                        break;
                    case 2:
                        Console.WriteLine("Torches cost 7.5 gold.");
                        break;
                    case 3:
                        Console.WriteLine("Climbing Equipment costs 12.5 gold.");
                        break;
                    case 4:
                        Console.WriteLine("Clean Water costs 0.5 gold.");
                        break;
                    case 5:
                        Console.WriteLine("Machetes cost 10 gold.");
                        break;
                    case 6:
                        Console.WriteLine("Canoes cost 100 gold.");
                        break;
                    case 7:
                        Console.WriteLine("Food Supplies costs 0.5 gold.");
                        break;
                }
            }
        }




    }
    
    internal class Problem4
    {
        static void Main(string[] args)
        {
            Console.Write("User 1, enter a number between 0 and 100: ");
            
            ThePrototype Solution4 = new ThePrototype();
            
            Solution4.PilotNumber = Convert.ToInt32(Console.ReadLine());


            while (Solution4.PilotNumber > 100 || Solution4.PilotNumber <0)
            {
                Console.Write("User 1, enter a number between 0 and 100: ");
                Solution4.PilotNumber = Convert.ToInt32(Console.ReadLine());
            }
            
            
            Console.Clear();

            Console.Write("User 2, guess the number.");

            Solution4.HunterNumber = Convert.ToInt32(Console.ReadLine());

            while (Solution4.HunterNumber != Solution4.PilotNumber)
            {
                if (Solution4.HunterNumber > Solution4.PilotNumber)
                { Console.WriteLine($"{Solution4.HunterNumber} is too high. "); }
                else { Console.WriteLine("Number too low. "); }
                
                Console.Write("What is your next guess: ");
                Solution4.HunterNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You guessed the number!");
        }

    }
    

    internal class Replicator
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(5);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Input 5 Numbers");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);

            }
            List<int> copy = new List<int>();

            foreach (int num in numbers)
            { copy.Add(num); }
            Console.WriteLine("Your Numbers");
            foreach (int i in numbers)
            {
                Console.Write(i + ", ");

            }
            Console.Write("\n");
            Console.WriteLine("Copy of your Numbers");
            foreach (int i in copy)
            {
                Console.Write(i + ", ");

            }
        }
    }
    */
}

