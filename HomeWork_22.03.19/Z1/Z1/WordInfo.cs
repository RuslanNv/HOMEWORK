using System;
using System.Collections.Generic;

namespace Z1
{
	public class WordInfo
	{
		public string Word { get; set; }
		public int Count { get; set; }

        public WordInfo(string word) { Word = word; Count = 1;}
	}
}
