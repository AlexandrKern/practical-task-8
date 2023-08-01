using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_8
{
    internal class Program
    {
       /// <summary>
       /// Заполнение листа
       /// </summary>
       /// <returns></returns>
        static List<int> Fill()
        {
            List<int> integers = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 100; i++)
                integers.Add(random.Next(100));
            return integers;
        }
        /// <summary>
        /// Вывод на консоль
        /// </summary>
        /// <param name="ints"></param>
        static void Print(List<int> ints)
        {
            for (int i = 0; i < ints.Count; i++)
                Console.WriteLine(ints[i]);
        }
        /// <summary>
        /// Удаление выбранного диапазона чисел
        /// </summary>
        /// <param name="ints"></param>
        /// <returns></returns>
        static List<int> Delete(List<int> ints)
        {
            for (int i = 0; i < ints.Count; i++)
            {
                    if (ints[i] > 25 && ints[i] < 50)
                    {
                      ints.RemoveAt(i); 
                      i--;
                    }
            }
            return ints;
        }
        static void Main(string[] args)
        {
            //Задание 1.Работа с листом.
            List<int> ints = Fill();
            Console.WriteLine("Случайные числа от 0 до 100");
            Print(ints);
            Console.WriteLine();
            Console.WriteLine("После удаления диапазона от 25 до 50");
            Print(Delete(ints));
        }
    }
}
