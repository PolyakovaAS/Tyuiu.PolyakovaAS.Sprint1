using Tyuiu.PolyakovaAS.Sprint1.Task5.V2.Lib;
Console.Title = "Спринт #1 | Выполнил: Полякова А. С. | ИСТНБ-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт 1                                                                *");
Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("*Выполнил: Полякова А. С. | ИСТНб-24-1                                    *");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая решает следующую задачу:                   * ");
Console.WriteLine("* Дано значение температуры в градусах Фаренгейта. Определить значение    *");
Console.WriteLine("* этой же температуры в градусах Цельсия.                                 *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
DataService ds = new DataService();
Console.WriteLine("Введите температуру в градусах Цельсия:");
double temp;
temp = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Температура в градусах Фаренгейта равна: " + ds.FahrenheitToСelsius(temp));
Console.ReadKey();




