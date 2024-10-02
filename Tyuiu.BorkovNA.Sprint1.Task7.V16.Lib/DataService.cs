﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BorkovNA.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            return Math.Round(Math.Sin(Math.Sqrt(Math.Pow(x, 2)))+(Math.Cos(Math.Pow(x,2)) /Math.Pow(3*x,3))-Math.Sin(Math.Sqrt(Math.Pow(x, 2)-1)),3);
        }
    }
}
