﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ООП_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 задание
            Pokupatel pokupatel1 = new Pokupatel();
            pokupatel1.firstName = "Василий";
            pokupatel1.lastName = "Пупкин";
            pokupatel1.middleName = "Петрович";
            pokupatel1.adres = "Москва";
            pokupatel1.numberCard = 123456789;
            pokupatel1.numberBank = 987654321;
            Console.WriteLine("Имя: " + pokupatel1.firstName);
            Console.WriteLine("Фамилия: " + pokupatel1.lastName);
            Console.WriteLine("Отчество: " + pokupatel1.middleName);
            Console.WriteLine("Адрес: " + pokupatel1.adres);
            Console.WriteLine("Номер кредитной карты: " + pokupatel1.numberCard);
            Console.WriteLine("Номер банскового счёта: " + pokupatel1.numberBank);
            Console.WriteLine();

            // 2 задание
            Abonent abonent1 = new Abonent();
            Console.Write("Введите идентификационный номер абонента: ");
            abonent1.iNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите имя абонента: ");
            abonent1.firstName = Console.ReadLine();
            Console.Write("Введите фамилию абонента: ");
            abonent1.lastName = Console.ReadLine();
            Console.Write("Введите отчество абонента: ");
            abonent1.middleName = Console.ReadLine();
            Console.Write("Введите время международных переговоров абонента: ");
            abonent1.timeMezh = Console.ReadLine();
            Console.Write("Введите время городских переговоров абонента: ");
            abonent1.timeGor = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Идентификационный номер: " + abonent1.iNumber);
            Console.WriteLine("Имя: " + abonent1.firstName);
            Console.WriteLine("Фамилия: " + abonent1.lastName);
            Console.WriteLine("Отчество: " + abonent1.middleName);
            Console.WriteLine("Время международных переговоров: " + abonent1.timeMezh);
            Console.WriteLine("Время городских переговоров: " + abonent1.timeGor);
            Console.WriteLine();

            // 3 задание
            ZooMarket zooMarket1 = new ZooMarket();
            Console.Write("Введите животное: ");
            zooMarket1.animal = Console.ReadLine();
            Console.Write("Введите пол животного \"" + zooMarket1.animal + "\": ");
            zooMarket1.gender = Console.ReadLine();
            Console.Write("Введите имя животного \"" + zooMarket1.animal + "\": ");
            zooMarket1.name = Console.ReadLine();
            Console.Write("Введите цену животного \"" + zooMarket1.animal + "\": ");
            zooMarket1.price = int.Parse(Console.ReadLine());
            Console.Write("Введите количество животных \"" + zooMarket1.animal + "\": ");
            zooMarket1.kol = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Животное: " + zooMarket1.animal);
            Console.WriteLine("Пол: " + zooMarket1.gender);
            Console.WriteLine("Имя: " + zooMarket1.name);
            Console.WriteLine("Цена: " + zooMarket1.price);
            Console.WriteLine("Количество: " + zooMarket1.kol);
            Console.ReadKey();
        }
    }
    class Pokupatel
    {
        public string firstName;
        public string lastName;
        public string middleName;
        internal string adres;
        internal int numberCard;
        internal int numberBank;
    }

    class Abonent
    {
        public int iNumber;
        public string firstName;
        public string lastName;
        public string middleName;
        internal string timeMezh;
        internal string timeGor;
    }
    
    class ZooMarket
    {
        public string animal;
        public string gender;
        public string name;
        internal int price;
        internal int kol;
    }
}
