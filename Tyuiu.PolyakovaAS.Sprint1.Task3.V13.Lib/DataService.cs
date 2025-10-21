


using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PolyakovaAS.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            int num = (int)number;
            int product = 1;

            while (num > 0)
            {
                product *= num % 10;
                num /= 10;
            }

            return product;
        }
    }
}
