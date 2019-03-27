using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace PackUnpack
{
	class Program
	{
		public static void Main()
		{
			string path = String.Format(@"C:\Users\Руслан\Desktop\Text\Base_text.txt");
			string writePath = String.Format(@"C:\Users\Руслан\Desktop\Text\Packed_text.txt");
			string writePath2 = String.Format(@"C:\Users\Руслан\Desktop\Text\Unpacked_text.txt");
			string text = File.ReadAllText(path, Encoding.GetEncoding("windows-1251"));
			Console.WriteLine(text.Length);
			StringBuilder sb_text = new StringBuilder(text);
			List<int> spaces;
			List<int> ns;
			Pack(sb_text, out spaces, out ns);
			File.WriteAllText(writePath, sb_text.ToString(), Encoding.GetEncoding("windows-1251"));
			Unpack(sb_text, spaces, ns);
			File.WriteAllText(writePath2, sb_text.ToString(), Encoding.GetEncoding("windows-1251"));
			Console.WriteLine("Готово");
			Console.ReadLine();
		}
		
		public static void Pack(StringBuilder _spaceless_text, out List<int> _spaces, out List<int> _ns)
		{
			_spaces = new List<int>();
			_ns = new List<int>();
			for(int i = _spaceless_text.Length-1; i >= 0; i--)
			{
				if(_spaceless_text[i] == ' ')
				{
					_spaces.Add(i);
					_spaceless_text = _spaceless_text.Remove(i,1);
				}
			}	
			for(int i = _spaceless_text.Length - 1; i >= 0; i--)
			{
				if(_spaceless_text[i] == '\n')
				{
					_ns.Add(i);
					_spaceless_text = _spaceless_text.Remove(i,1);
				}
			}
		}
		
		public static void Unpack(StringBuilder _spaceless_text, List<int> _spaces, List<int> _ns)
		{
			for(int i = _ns.Count - 1 ; i >= 0; i--)
			{
				_spaceless_text = _spaceless_text.Insert(_ns[i], "\n");
			}
			for(int i = _spaces.Count - 1 ; i >= 0; i--)
			{
				_spaceless_text = _spaceless_text.Insert(_spaces[i], " ");
			}
		}
	}
}