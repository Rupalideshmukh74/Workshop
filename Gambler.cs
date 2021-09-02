using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Gambler
    {
        public void gambling()
        {
            const int gamestake = 100;
            const int gamebet = 1;
            Console.WriteLine("Initial value:\t Stake=${0}\t Bet per game=${1}",gamestake,gamebet);
        }
        public void Win_or_loss()
        {
            Random random = new Random();
            int Check = random.Next(0, 2);

            if (Check == 0)
            {
                Console.WriteLine("Gambler lost $1");
            }
            else
            {
                Console.WriteLine("Gambler won $1");
            }
        }
    }
}
