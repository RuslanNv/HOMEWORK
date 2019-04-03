
using System;

namespace Bingo
{
	public class Game
	{
			int _maxValue;
			
			bool _gameWasWon = false;
			
			public bool GameWasWon
			{
				get{ return _gameWasWon;}
			}
			
			public int Seconds
			{
				get { return _maxValue / 2;}
						
			}
			
			public void SetValue()
			{
				Console.WriteLine("Введите максимальное число для отгадывания");
				_maxValue = int.Parse(Console.ReadLine());
			}
			
			public void GameItself()
			{
				Console.WriteLine("Отгадываем число от 1 до {0}. На отгадывание {1} секунд", _maxValue, Seconds);
				Random rnd = new Random();
				int currentValue = rnd.Next(1, _maxValue);
				int playerValue;
				do
				{
					playerValue = int.Parse(Console.ReadLine());
					if(playerValue > currentValue)
						{Console.WriteLine("Вы ввели больше");}
					else if(playerValue < currentValue)
						{Console.WriteLine("Вы ввели меньше");}
				}
				while(playerValue != currentValue);
				_gameWasWon = true;
				Console.WriteLine("Верно. Загаданное число : {0}", currentValue);
			}
			
	}
}
