using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinCountOfCoins
{
    class Program
    {
        static int[][] MinCountOfCoins(int[] values, int sum)
        {
            int[][] min = new int[sum + 1][];
            int maxValue = values.Max() + 1;
            for (int i = 0; i < min.Length; i++)
            {
                min[i] = new int[maxValue];
                min[i][0] = int.MaxValue;
            }
            Console.WriteLine("HAHAHAHAHA");
            Console.WriteLine("HAHAHAHAHA");
            Console.WriteLine("HAHAHAHAHA");
            Console.WriteLine("HAHAHAHAHA");
            Console.WriteLine("HAHAHAHAHA");
            min[0][0] = 0;
            for (int i = 1; i < min.Length; i++)
                for (int j = 0; j < values.Length; j++)
                {
                    if (values[j] <= i && min[i - values[j]][0] + 1 < min[i][0])
                    {
                        min[i][0] = min[i - values[j]][0] + 1;

                        min[i][values[j]] += 1;
                    }
                }

            return min;//min[min.Length - 1][0];
        }

        static void Main(string[] args)
        {
            int[] values = new int[] { 1, 3, 5, 7 };
            int sum = 11;
            Console.WriteLine("Min count of coins to sum up {0}: {1}", sum, MinCountOfCoins(values, sum)[sum][0]);
            foreach (var collect in MinCountOfCoins(values,sum))
            {
                foreach (var item in collect)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
