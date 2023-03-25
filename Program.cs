using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Create a game-loop and a start-label
            // 0 - rock 1 - paper 2 - scissors
            int userChoose = -1;
            int botChoose = -1;
            int userWinCount = 0;
            int botWinCount = 0;
            Console.WriteLine("Its a ROCK-PAPER-SCISSORS game!");
            Console.WriteLine("Computer will play againts u");
            Console.WriteLine("Use numbers for choose a thing(0 - rock 1 - paper 2 - scissors)");
            Random botRandChoose = new Random();
            while (userWinCount < 3 && botWinCount < 3)
            {
                while (userChoose < 0 || userChoose > 2)
                {
                    Console.Write("Write a number(0,1,2): ");
                    userChoose = Convert.ToInt32(Console.ReadLine());
                }

                botChoose = botRandChoose.Next(0, 3);

                Console.WriteLine($"Bot choose is {botChoose}");

                if (botChoose > userChoose || (botChoose == 0 && userChoose == 3))
                {
                    //botWinsCount++
                    Console.WriteLine("Bot win!");
                    botWinCount++;
                }

                else if(userChoose > botChoose || (userChoose == 0 && botChoose == 3))
                {
                    Console.WriteLine("User win!");
                    userWinCount++;
                }

                else
                {
                    Console.WriteLine("Draw!");
                }

                userChoose = -1;
                Console.WriteLine("\n");
            }
            Console.WriteLine($"\n\nUser : {userWinCount}   Bot : {botWinCount}");
            if(userWinCount > botWinCount)
            {
                Console.WriteLine("\n\nUser WIN!");
            }
            else
            {
                Console.WriteLine("\n\nBot WIN!");
            }
            Console.ReadLine();
        }
    }
}
