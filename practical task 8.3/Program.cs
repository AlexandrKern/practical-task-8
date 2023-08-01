using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 3. Проверка повторов
            HashSet<int> set = new HashSet<int>();
            while (true)
            {
                Console.WriteLine("Введите любое число кроме ноля : ");
                Console.WriteLine("Введите 0 выход из программы");
                int a = int.Parse(Console.ReadLine());
                if (a == 0) break;
                if (set.Contains(a))
                {
                    Console.WriteLine("Указанное число уже есть! Введите другое.");
                    continue;
                }
                set.Add(a);
                Console.WriteLine("Число успешно сохранено. ");
            }
        }
    }
}
