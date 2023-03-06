// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.Write("Введите первую координату 1-й прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вторую координату 1-й прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите первую координату 2-й прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вторую координату 2-й прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
Console.WriteLine($"({Math.Round(x, 2)}, {Math.Round(y, 2)})");