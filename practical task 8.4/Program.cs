using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace practical_task_8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 4.Записная книжка
            XElement myPerson = new XElement("Person");
            XElement myAddress = new XElement("address");
            XElement myStreet = new XElement("Street");
            XElement myHouseNumber = new XElement("HouseNumber");
            XElement myFlatNumber = new XElement("FlatNumber");
            XElement myPhones = new XElement("Phones");
            XElement myMobilePhone = new XElement("MobilePhone");
            XElement myFlatPhone = new XElement("FlatPhone");
            Console.Write("Введите полное имя: ");
            string add = Console.ReadLine();
            XAttribute xAttributePerson = new XAttribute("name",add);
            Console.Write("Введите название улицы: ");
            add = Console.ReadLine();
            myStreet.Add(add);
            Console.Write("Ведите номер дома: ");
            add = Console.ReadLine();
            myHouseNumber.Add(add);
            Console.Write("Ведите номер квартиры: ");
            add = Console.ReadLine();
            myFlatNumber.Add(add);
            Console.Write("Ведите номер мобильного телефона: ");
            add = Console.ReadLine();
            myMobilePhone.Add(add);
            Console.Write("Ведите номер домашенго телефона: ");
            add = Console.ReadLine();
            myFlatPhone.Add(add);
            myPerson.Add(xAttributePerson);
            myPerson.Add(myAddress);
            myAddress.Add(myStreet, myHouseNumber, myFlatNumber);
            myPerson.Add(myPhones);
            myPhones.Add(myMobilePhone, myFlatPhone);
            myPerson.Save("Записная книжка.xml");
        }
    }
}
