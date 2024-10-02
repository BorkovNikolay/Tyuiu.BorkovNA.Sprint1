using System;
using Tyuiu.BorkovNA.Sprint1.Task3.V1.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле a*b*c/(a+b+c) и печатает его на экране.


namespace Tyuiu.BorkovNA.Sprint1.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Cпринт #1 | Выполнил: Борков Н. А. | пктб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Операторы составного присваения                                    *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнил: Борков Н. А. | пктб-24-1                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите радиус");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту");
            int b = Convert.ToInt32(Console.ReadLine());
            double res = ds.CylinderVolume(a, b);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Результат = " + res);
            Console.ReadKey();

        }
    }

}