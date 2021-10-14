using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра
            string startString = Console.ReadLine(); //пишем строку
            startString = startString.Replace(" ", string.Empty); //заменяем пробелы, объединяя все в одно слово
            startString = startString.ToLower(); //переводим в нижний регистр
            string newString = new string(startString.Reverse().ToArray()); //переворачиваем
            if (startString == newString)
            {
                Console.WriteLine("Данное предложение является палиндромом"); //сравниваем
            }
            else
            {
                Console.WriteLine("Данное предложение не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
