using System;
using Tyuiu.BorkovNA.Sprint1.Task1.V29.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле a*b*c/(a+b+c) и печатает его на экране.


namespace Tyuiu.BorkovNA.Sprint1.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Cпринт #1 | Выполнил: Борков Н. А. | пктб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #29                                                              *");
            Console.WriteLine("* Выполнил: Борков Н. А. | пктб-24-1                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет результат по формуле a*b*c/(a+b+c) и печатает его на экране.   *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите число a");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            double c = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(a, b, c);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Результат = " + res);
            Console.ReadKey();

        }
    }

}