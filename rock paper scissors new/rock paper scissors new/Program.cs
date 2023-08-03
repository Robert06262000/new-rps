using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors_new
{
    internal class Program
    {
        static int win = 0, lose = 0, tie = 0;
        static void Main(string[] args)
        {
            Dictionary<string, int> rpsDict = new Dictionary<string, int>()
            {
                {"r", 1 },
                {"p", 2 },
                {"s", 3 }
            };
            while (true) {
                string input = "";
                while (!rpsDict.ContainsKey(input))
                {
                    Console.WriteLine("Rock Paper Scissors \n Select: r/p/s");
                    input = Console.ReadLine();
                }
                int inputValue = rpsDict[input];
                Console.WriteLine(rpsGame(inputValue));
                Console.WriteLine($"\nWins:{win}\tLoses:{lose}\t Ties:{tie}");
                Console.WriteLine("Play again? (y/n)");
                string ans = Console.ReadLine();
                if (ans != "y")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\n\n");
                }
            }
        }

        static string rpsGame(int input)
        {
            Dictionary<int, string> rpsDict2 = new Dictionary<int, string>()
            {
                {1, "rock"},
                {2, "paper"},
                {3, "scissors"}
            };
            var r = new Random();
            var opponent = r.Next(4); //>=0 or <4 1=r, 2=p, 3=s
            Console.WriteLine($"Your opponent picked: {rpsDict2[opponent]}!");
            string res = "";
            switch(input){
                case 1:
                    if (opponent == 1)
                    {
                        res = "Tie";
                        resultAdd(res);
                    }
                    else if (opponent == 2)
                    {
                        res = "Lose";
                        resultAdd(res);
                    }
                    else
                    {
                        res = "Win";
                        resultAdd(res);
                    }
                    break;
                case 2:
                    if (opponent == 1)
                    {
                        res = "Win";
                        resultAdd(res);
                    }
                    else if (opponent == 2)
                    {
                        res = "Tie";
                        resultAdd(res);
                    }
                    else
                    {
                        res = "Lose";
                        resultAdd(res);
                    }
                    break;
                case 3:
                    if (opponent == 1)
                    {
                        res = "Lose";
                        resultAdd(res);
                    }
                    else if (opponent == 2)
                    {
                        res = "Win";
                        resultAdd(res);
                    }
                    else
                    {
                        res = "Tie";
                        resultAdd(res);
                    }
                    break;
            }
                    return res;
        }

        static void resultAdd(string res)
        {
            if (res == "Win")
            {
                win++;
            }
            else if (res == "Lose")
            {
                lose++;
            }
            else
            {
                tie++;
            }
        }
    }
}
