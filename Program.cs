using System;
using System.IO;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");
        Random rand = new Random();
        string[] array = { "stone", "scissors", "paper" };
        Console.WriteLine("Please select the command:");
        Console.WriteLine("Stone");
        Console.WriteLine("Scissors");
        Console.WriteLine("Paper");
        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine();
            Console.Write("> "); 
            string input = Console.ReadLine();
            input = input.ToLower();
            int userInput = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (input == array[i])
                {
                    userInput = i;
                    break;
                }
            }
            if (userInput == -1)
            {
                Console.WriteLine("Unacceptable! Stop doing that!");
                x = x - 1;
                continue;
            }

            int pcInput = rand.Next(array.Length);
            Console.WriteLine("PC turn: " + array[pcInput]);
            if (userInput == pcInput)
            {
                Console.WriteLine("No one won(");
            }
            else if ((userInput == 0 && pcInput == 2) || userInput == pcInput + 1)
            {
                Console.WriteLine("Defeat!");
            }
            else
            {
                Console.WriteLine("Victory!");
            }
        }
    }
}