

using Tyuiu.PolyakovaAS.Sprint1.Task2.V1.Lib;

using System;

namespace Tyuiu.PolyakovaAS.Sprint1.Task2.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Полякова А.С. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Арифметические операторы в C#                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Полякова А.С. | ИСТНБ-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Известно расстояние в километрах. Вычислить расстояние в милях.         *");
            Console.WriteLine("* При условии, что 1 миля = 1,609 км. Ответ округлить до 3 знаков.       *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int km;

            Console.WriteLine("Введите расстояние в километрах: ");
            km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine("Расстояние в милях = " + ds.ConvertKmToM(km));
            Console.ReadKey();
        }
    }
}