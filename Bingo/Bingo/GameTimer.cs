using System;

namespace Bingo
{
	public class GameTimer
	{
		int _seconds;
		
		public int Seconds
		{
			get{return _seconds;}
		}
		
		public GameTimer(int seconds)
		{
			_seconds = seconds;
		}
		
		public void Tick(object obj)
		{
			Console.WriteLine("Осталось {0} секунд", _seconds-- );
		}
	}
}
