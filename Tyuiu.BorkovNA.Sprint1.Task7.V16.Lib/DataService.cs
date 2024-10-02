﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BorkovNA.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            return Math.Round((Math.Sin(Math.Sqrt(x*x)))+(Math.Cos(x*x)/ (3 * Math.Pow(x,3)))-(Math.Sin(Math.Sqrt((x*x)-1))),3);
        }
    }
}
