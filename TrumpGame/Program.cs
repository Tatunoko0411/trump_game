using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cards = new int[4];

            //四回入力
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{i+1}番目の数字を入力(1-4)>");

                //チェック
                if(!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("1-4で入力");
                    i--;
                    continue;
                }

                cards[i] = input;

            }

            foreach (int i in cards)
            {
                Console.WriteLine($"{i}");
            }

            Console.ReadLine();
            return;
        }
    }
}
