
using Tyuiu.PolyakovaAS.Sprint1.Task3.V13.Lib;

namespace Tyuiu.PolyakovaAS.Sprint1.Task3.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Полякова А. С. | ИСТНБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Полякова А.С                 | АСОиУБ-23-2                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая объявляет необходимые переменные, выполняет *");
            Console.WriteLine("* указанные расчёты и печатает результат на экране.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int numbers = 222;
            int number = 2;
            Console.WriteLine("Заданое трехзначное число = " + numbers);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение цифр заданого числа = " + ds.MultiplyOfDigits(number));
            Console.ReadKey();



        }
    }
}