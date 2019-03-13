using System;

namespace HomeWork2
{
    class Program
    {
        static void Main()
        {
            int[] a = { 121, 144, 19, 161, 19, 144, 19, 11};
            int[] b = { 121, 14641, 20736, 361, 25921, 361, 20736, 361};
            Console.WriteLine(comp(a,b));
            Console.WriteLine();
            b = new int[]{ 132, 14641, 20736, 361, 25921, 361, 20736, 361 };
            Console.WriteLine(comp(a, b));
            Console.WriteLine();
            b = new int[]{ 132, 14641, 20736, 36100, 25921, 361, 20736, 361 };
            Console.WriteLine(comp(a, b));
            Console.WriteLine();
            a = new int[] { 2, 11, 7, 1, 3, 9, 7 };
            b = new int[] { 49, 81, 4, 121, 9, 1, 49 };
            Console.WriteLine(comp(a, b));
            Console.ReadLine();
        }

        public static bool comp(int[] a, int[] b)
        {
            Array.Sort(a);
            Array.Sort(b);
            if(a != null | b != null | a.Length != 0 | b.Length != 0 | a.Length != b.Length)
            {
                for(int i = 0; i < a.Length; i++)
                {
                    if(b[i] != Math.Pow(a[i], 2))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
