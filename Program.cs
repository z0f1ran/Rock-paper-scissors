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
            Console.WriteLine("Its a ROCK-PAPER-SCISSORS game!");
            Console.WriteLine("Computer will play againts u");
            Console.WriteLine("Use numbers for choose a thing(0 - rock 1 - paper 2 - scissors)");
            Random botRandChoose = new Random();
            while (true)
            {
                while (userChoose < 0 || userChoose > 2)
                {
                    Console.Write("Write a number(0,1,2): ");
                    userChoose = Convert.ToInt32(Console.ReadLine());
                }

                botChoose = botRandChoose.Next(0, 3);

                Console.WriteLine("Bot Choose is",botChoose);

                if (botChoose > userChoose || (botChoose == 0 && userChoose == 3))
                {
                    //botWinsCount++
                    Console.WriteLine("Bot win!");
                }

                else if(userChoose > botChoose || (userChoose == 0 && botChoose == 3))
                {
                    Console.WriteLine("User win!");
                }

                else
                {
                    Console.WriteLine("Draw!");
                }

                userChoose = -1;
            }
        }
    }
}
