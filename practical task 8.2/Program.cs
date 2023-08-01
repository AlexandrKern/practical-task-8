using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_8._2
{
    internal class Program
    {    
        /// <summary>
        /// Заполнение телефонной книги
        /// </summary>
        static Dictionary<string, string> FillPhoneBook()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            Console.WriteLine("Заполнение телефонной книги.");
            while (true)
            {
                Console.Write("Введите номер телефона: ");
                string phoneNumber = Console.ReadLine();
                if (phoneNumber == "") break;
                    if (phoneBook.ContainsKey(phoneNumber))
                    {
                        Console.WriteLine($"Номер телефона уже существует у : {phoneBook[phoneNumber]}");
                        continue;
                    }
                Console.Write("Введите полное имя: ");
                string fullName = Console.ReadLine();
                phoneBook.Add(phoneNumber, fullName);
            }
            return phoneBook;
        }
        /// <summary>
        /// Поиск абонента по номеру телефона
        /// </summary>
        /// <param name="phoneBook"></param>
        static void Search(Dictionary<string, string> phoneBook)
        {
            Console.Clear();
            Console.WriteLine("Поиск абонента по номеру телефона.");
            while (true)
            {
                Console.Write("Введите номер: ");
                string phoneNumber = Console.ReadLine();
                if (phoneNumber == "") break;
                if (phoneBook.ContainsKey(phoneNumber))
                    Console.WriteLine(phoneBook[phoneNumber]);
                else Console.WriteLine("Абонента с таким номер нет!");
            }
        }
        static void Main(string[] args)
        {
            //Задание 2.Телефонная книга.
            Dictionary<string, string> phoneBook = FillPhoneBook();
            Console.WriteLine();
            Search(phoneBook);
        }
    }
}
