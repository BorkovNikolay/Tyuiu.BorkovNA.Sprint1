using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BorkovNA.Sprint1.Task4.V22.Lib
{
    public class DataService : ISprint1Task4V22
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Sqrt(x * y)/(1+(x+2*y)*(x + 2 * y)),3);
        }
    }
}
