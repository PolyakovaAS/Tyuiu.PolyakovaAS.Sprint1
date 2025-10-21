

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PolyakovaAS.Sprint1.Task1.V16.Lib
{
    public class DataService : ISprint1Task1V16
    {
        public double Calculate(double a, double x, double y)
        {
            return (x * y * 5 + 2 * a * x);
        }
    }
}
