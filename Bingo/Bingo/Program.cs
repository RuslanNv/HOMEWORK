using System;
using System.Threading;


namespace Bingo
{
	class Program
	{
		public static void Main()
		{
			Menu();
			Console.ReadLine();
		}
		
		public static void Menu()
		{
			int choice;
			do
			{
				Console.WriteLine("1 - установить значение и начать игру, 2 - выход");
				choice = int.Parse(Console.ReadLine());
				switch(choice)
				{
					case 1:
						PlayGame();
						break;
					case 2:
						break;
					default:
						Console.WriteLine("Неправильное значение");
						break;
				}
			}
			while(choice != 2);
		}
		
		public static void PlayGame()
		{
			int currentSecond;
			Game game = new Game();
			game.SetValue();
			GameTimer gtimer = new GameTimer(game.Seconds);
			Thread thread = new Thread(game.GameItself);
			TimerCallback tmc = new TimerCallback(gtimer.Tick);
			thread.Start();
			Timer timer = new Timer(tmc, null, 0, 1000);
			do
			{
				currentSecond = gtimer.Seconds;
				if(game.GameWasWon)
				{
					timer.Dispose();
					thread.Abort();
					break;
				}
			}
			while(currentSecond != 0);
			timer.Dispose();
			if(!game.GameWasWon)
			{
				thread.Abort();
				Console.WriteLine("Время вышло, игра проиграна");
			}
			Console.ReadLine();
		}
	}
}