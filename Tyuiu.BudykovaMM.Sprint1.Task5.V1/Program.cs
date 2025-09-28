using Tyuiu.BudykovaMM.Sprint1.Task5.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Будыкова М. М. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Будыкова Мадина Маратовна | ПИНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу: Найти расстояние   *");
        Console.WriteLine("* между двумя точками с заданными координатами(x, y).                     *");
        Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
         
        Console.WriteLine("Введите значение X1:");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y1:");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение X2:");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y2:");
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2));
        Console.WriteLine(res);
        Console.ReadKey();
    }
}