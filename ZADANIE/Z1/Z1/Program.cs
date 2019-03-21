using System;
using System.Collections.Generic;


namespace Z1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(MakeSyllable("конкатенация"));
            Console.WriteLine(MakeSyllable("метроидвания"));
            Console.WriteLine(MakeSyllable("корелляция"));
            Console.WriteLine(MakeSyllable("объезд"));
            Console.WriteLine(MakeSyllable("контрстрельба"));
            Console.WriteLine(MakeSyllable("аэродинамический"));
            Console.WriteLine("Введите слово");
            string str = Console.ReadLine();
            Console.WriteLine(MakeSyllable(str));
            Console.ReadLine();
        }


        public static string MakeSyllable(string word)
        {
            string[] glas = { "а", "у", "е", "ё", "ы", "о", "я", "и", "э", "ю" };
            word = word.ToLower();

            List<int> glasPositions = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                string symbol = word.Substring(i, 1);
                for (int j = 0; j < glas.Length; j++)
                {
                    if (symbol == glas[j])
                    {
                        glasPositions.Add(i);
                        break;
                    }
                }
            }
            string result = string.Empty;
            for (int i = glasPositions.Count - 1; i > 0; i--)
            {
                string symbol = word.Substring(glasPositions[i] - 1, 1);
                if (symbol == "ь" || symbol == "ъ")
                {
                    result = "-" + word.Substring(glasPositions[i]) + result;
                    word = word.Remove(glasPositions[i]);
                }
                else
                {
                    int n = glasPositions[i] - glasPositions[i - 1] - 1;
                    int ind = glasPositions[i - 1] + 1 + n / 2;
                    symbol = word.Substring(ind, 1);
                    if (symbol == "ь" || symbol == "ъ") ind++;
                    result = "-" + word.Substring(ind) + result;
                    word = word.Remove(ind);
                }

            }
            result = word + result;
            return result;
        }

    }

}
