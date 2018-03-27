using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Triplets comparison
            string[] AlicesTriplet = Console.ReadLine().Split(' ');
            string[] BobTriplet = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(AlicesTriplet[0]);
            int a1 = Convert.ToInt32(AlicesTriplet[1]);
            int a2 = Convert.ToInt32(AlicesTriplet[2]);
            int b0 = Convert.ToInt32(BobTriplet[0]);
            int b1 = Convert.ToInt32(BobTriplet[1]);
            int b2 = Convert.ToInt32(BobTriplet[2]);
            solve(a0, a1, a2, b0, b1, b2);*/

            //Min-Max sum 4 out of 5 integers
            double[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToDouble(arrTemp));        
            miniMaxSum(arr);
            Console.Read();
        }

        /// <summary>
        /// Triplets comparison
        /// </summary>
        /// <param name="a0"></param>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <param name="b0"></param>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int AliceCount = 0;
            int BobCount = 0;

            if (a0 > b0)
            {
                AliceCount++;
            }
            else if (b0 > a0)
            {
                BobCount++;
            }

            if (a1 > b1)
            {
                AliceCount++;
            }
            else if (b1 > a1)
            {
                BobCount++;
            }

            if (a2 > b2)
            {
                AliceCount++;
            }
            else if (b2 > a2)
            {
                BobCount++;
            }

            return new int[2] { AliceCount, BobCount };
        }

        static void miniMaxSum(double[] arr)
        {
            Array.Sort(arr);

            double min = arr[0] + arr[1] + arr[2] + arr[3];
            double max = arr[4] + arr[1] + arr[2] + arr[3]; ;

            //for (int i = 0; i < arr.Length-1; i++)
            //{
            //    min += arr[i];
            //    max += arr[i + 1];
            //}

            Console.WriteLine(min + " " + max);
        }

    }
}
