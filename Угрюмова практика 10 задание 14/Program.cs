using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Угрюмова_практика_10_задание_14
{
    class Program
    {
        static int[,] Poezd_Random(int [,] array)
        {
            Random rnd = new Random();
            for(int i = 0; i< array.GetLength(0); i++)
            {
                for(int j =0; j< array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 2);
                }
            }
            return array;
        }

        static int[,] Poezd_Sam(int [,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    while (true)
                    {
                        Console.WriteLine($"Введите заполнено ли место {j + 1} в {i + 1} вагоне");
                        array[i, j] = int.Parse(Console.ReadLine());
                        if (array[i, j] == 1 || array[i, j] == 0) break;
                        else Console.WriteLine("такого значения не может быть");
                    }
                }
            }
            return array;
        }
        static void Show(int [,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] +" ");
                }
                Console.WriteLine();
            }
        }
        static int [] Chet(int[,] array)
        {
            int[] chet = new int[10];
            for(int i = 0; i< array.GetLength(0); i++)
            {
                for(int j = 0; j< array.GetLength(1); j++)
                {
                    if(array[i,j] == 0)
                    {
                        chet[i]++;
                    }
                }
            }
            return chet;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int [,] array = new int [10, 36];
                    Console.WriteLine("вы хотите написать самостоятельно?");
                    string answer = Console.ReadLine();
                    if (answer == "да") Poezd_Sam(array);
                    else
                    {
                        if (answer == "нет") Poezd_Random(array);
                    }
                    Show(array);
                    int[] chet = Chet(array);
                    for(int i = 0; i< 10; i++)
                    {
                        Console.WriteLine($"{chet[i]} свободных мест в {i+1} вгоне");
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("ошибка в наборе");
                }
            }
            Console.ReadKey();
        }
    }
}
