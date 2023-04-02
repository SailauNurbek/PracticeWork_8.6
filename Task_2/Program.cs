using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Task_2
{
    internal class Program
    {
        /// <summary>
        /// Добавляем пользователя
        /// </summary>
        /// <returns></returns>
        static Dictionary<string, string> AddUser(Dictionary<string, string> phoneBook)
        {
            string numer = string.Empty;
            string name = string.Empty;            

            Console.WriteLine("Введите ФИО владельца телефона: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите номер телефона, ввод пустой строки конец ввода:");            
            while (true)
            {
                numer = Console.ReadLine();
                if (numer == "") break; //Проверка конца номера                    
                phoneBook.Add(numer, name);
            }
            Console.WriteLine("Пользователь добавлен\n");
            return phoneBook;
        }

        /// <summary>
        /// Находим пользователя по ключу
        /// </summary>
        /// <param name="phoneBook">Там где надо искать</param>
        /// <param name="numer">номер</param>
        /// <returns></returns>
        static void FindUser(Dictionary<string, string> phoneBook, string numer)
        {            
            if (phoneBook.Keys.Contains(numer)) //Возвращает true если dictionary содержить значение по ключу
            {
                string owner;
                phoneBook.TryGetValue(numer, out owner);
                Console.WriteLine($"Владелец телефона: {owner}\n");
            }
            else
            {
                Console.WriteLine("Такого пользователя нет\n");
            }
        }


        static void Main(string[] args)
        {           
            Dictionary<string, string> phoneBook = new();            
            AddUser(phoneBook);
            while (true)
            {
                Console.WriteLine("Пойск пользователя 1, добавить пользователя 2: ");            
                string change = Console.ReadLine();
                if (change == "1")
                {
                    Console.WriteLine("Поиск владельца по номеру телефона. Введите номер: ");
                    string numer = Console.ReadLine();
                    FindUser(phoneBook, numer);
                }
                else if (change == "2") 
                {                    
                    AddUser(phoneBook);
                }                            
            }
        }
    }
}