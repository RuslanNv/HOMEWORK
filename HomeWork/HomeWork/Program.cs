using System;
using System.Text;

namespace HomeWork
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n{0}",Missing("123567"));
            Console.WriteLine("\n{0}",Missing("599859996001"));
            Console.WriteLine("\n{0}", Missing("899091939495"));
            Console.WriteLine("\n{0}", Missing("9899101102"));
            Console.WriteLine("\n{0}", Missing("599600601602"));
            Console.WriteLine("\n{0}", Missing("8990919395"));
            Console.WriteLine("\n{0}", Missing("9899100101102103105"));
            Console.WriteLine("\n{0}", Missing("99101"));
            Console.ReadLine();
        }

        static int Missing(string str)
        {
            int[] startArray = new int[str.Length]; 
            int[] array;
            int length;
            int startMassiveLength = 0;
            int sequence = 0;
            int missing = 0;
            int num = 0;
            int arrNum = 0;
            for (int i = 1; i <= str.Length/2; i++)     //цикл определяет изначальную длину числа(2х зн. 3х зн. и тд)
            {
                for (int j = 0; j < startArray.Length; j++) //заполняем начальный массив единицами
                {
                    startArray[j] = -1;
                }

                startMassiveLength = 0;
                sequence = 0;
                missing = 0;
                length = i;
                num = 0;
                arrNum = 0;

                while(num <= str.Length-length)     //заполняем стартовый массив числами с учетом того,
                                                    //что длина числа может увеличится
                {
                    if ((str.Substring(num, length) == "9") | (str.Substring(num, length) == "99") 
                        | (str.Substring(num, length) == "999") | (str.Substring(num, length) == "9999"))   //если возвращаемая подстрока
                                                                                                            //равна одному из 4х данных значений
                                                                                                            //логично предположить что у следующего числа
                                                                                                            //длина больше на 1
                    {
                        startArray[arrNum] = int.Parse(str.Substring(num, length));
                        num += length;
                        length++;
                    }
                    else
                    {
                       startArray[arrNum] = int.Parse(str.Substring(num, length));
                       num += length;
                    }
                    arrNum++;
                    
                }
                
                for(int j = 0; j < startArray.Length; j++)  //проверяем количество ячеек стартового массива, не равных -1
                                                            //создаем рабочий массив на основе этого количества
                {
                    if(startArray[j] != -1)
                    { startMassiveLength++; }
                }
                array = new int[startMassiveLength];

                for (int j = 0; j < array.Length; j++)  //заполняем рабочий массив
                {
                    array[j] = startArray[j];
                }

                for (int j = 0; j < array.Length - 1; j++)  //проверяем рабочий массив на правильный порядок
                {
                    if(array[j+1] - array[j] == 1)
                    {
                        sequence++; 
                    }
                    else if(array[j + 1] - array[j] == 2)
                    {
                        missing = array[j] + 1;
                    }
                }

                if (sequence != 0)
                {
                    if (sequence == array.Length - 1)
                    {
                        return -1;
                    }
                    else if (sequence == array.Length - 2)
                    {
                        return missing;
                    }
                }
                else if ((sequence == 0) && (missing != 0) && (array.Length == 2))
                    return missing;
                //Console.WriteLine();
            }
            return -1;
        }
    }
}
