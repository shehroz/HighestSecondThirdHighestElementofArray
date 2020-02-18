using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 5, 7, 2 };
            int[] arr = { 1, 5, 7, 2, 12, 8, 20 };
            int[] result = HighestArray(arr);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadKey();

        }

        public static int[] HighestArray(int[] arr)
        {
            int[] result = new int[3];
            int max = arr[0], smax = arr[0], tmax = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    if (smax < max)
                        smax = max;
                    else if (tmax < smax)
                        tmax = smax;

                    max = arr[i];
                }
                else if (arr[i] > smax)
                {
                    if (tmax < smax)
                        tmax = smax;

                    smax = arr[i];
                }
                else if (arr[i] > tmax)
                    tmax = arr[i];

            }
            result[0] = max;
            result[1] = smax;
            result[2] = tmax;

            return result;
        }

    }
}
