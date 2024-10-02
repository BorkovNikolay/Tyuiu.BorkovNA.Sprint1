using System;
using Tyuiu.BorkovNA.Sprint1.Task2.V18.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле a*b*c/(a+b+c) и печатает его на экране.


namespace Tyuiu.BorkovNA.Sprint1.Task1.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Cпринт #1 | Выполнил: Борков Н. А. | пктб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                      *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #18                                                              *");
            Console.WriteLine("* Выполнил: Борков Н. А. | пктб-24-1                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите длину");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту");
            int c = Convert.ToInt32(Console.ReadLine());
            int res = ds.CalculateSideSquareParallelepiped(a, b, c);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Результат = " + res);
            Console.ReadKey();

        }
    }

}