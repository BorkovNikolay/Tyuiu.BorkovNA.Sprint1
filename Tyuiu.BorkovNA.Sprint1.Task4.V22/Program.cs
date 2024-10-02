using System;
using Tyuiu.BorkovNA.Sprint1.Task4.V22.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле a*b*c/(a+b+c) и печатает его на экране.


namespace Tyuiu.BorkovNA.Sprint1.Task4.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Cпринт #1 | Выполнил: Борков Н. А. | пктб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Class Math                                                         *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #22                                                              *");
            Console.WriteLine("* Выполнил: Борков Н. А. | пктб-24-1                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите x");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int b = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(a, b);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Результат = " + res);
            Console.ReadKey();

        }
    }

}