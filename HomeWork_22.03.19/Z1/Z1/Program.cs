using System;
using System.Collections.Generic;

namespace Z1
{
	class Program
	{
		public static void Main()
		{
			string str = "Ехал Грека Через Реку Видит Грека В Реке Рак сунул грека руку в реку рак за руку греку ЦАП";
			string lowerString = str.ToLower();
			string[] array = lowerString.Split(' ');
			Array.Sort(array);
			List<WordInfo> listOfWords = new List<WordInfo>();
			for(int i = 0, l = 0; i < array.Length; l++)
			{
                int step = 1;
                listOfWords.Add(new WordInfo(array[i]));
				for(int j = i + 1; j < array.Length ;j++)
				{
					if(array[j] == array[i])
					{
						listOfWords[l].Count++;
						step++;
				    }
                }
                i += step;
			}
			Console.WriteLine();
			foreach(WordInfo wf in listOfWords)
				Console.WriteLine("{0}: {1}", wf.Word, wf.Count);
			Console.ReadLine();
		}
	}
}