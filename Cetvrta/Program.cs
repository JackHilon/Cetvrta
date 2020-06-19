using System;
using System.Collections.Generic;

namespace Cetvrta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cetvrta 
            // https://open.kattis.com/problems/cetvrta

            var reslut = FourthPoint(Enter3Points());
            Console.WriteLine($"{reslut[0]} {reslut[1]}");
        }
        private static int[] FourthPoint(List<int> arr)
        {
            int[] res = new int[2] { 0, 0 };

            res[0] = DistinctElement(arr[0], arr[2], arr[4]);
            res[1] = DistinctElement(arr[1], arr[3], arr[5]);

            return res;
        }

        private static int DistinctElement(int a, int b, int c)
        {
            if (a == b)
                return c;
            else if (b == c)
                return a;
            else return b;
        }

        private static List<int> Enter3Points()
        {
            string[] arr = new string[2] { "", "" };
            List<int> res = new List<int>();
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    arr = Console.ReadLine().Split(' ', 2);
                    for (int j = 0; j < arr.Length; j++)
                    {
                        res.Add( int.Parse(arr[j]));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message+" || "+ex.GetType().ToString());
                return Enter3Points();
            }
            return res;
        }
    }
}
