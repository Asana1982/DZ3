// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату A: ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату B: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату C: ");
double c1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату A: ");
double a2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату B: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату C: ");
double c2 = Convert.ToDouble(Console.ReadLine());
double l = Math.Round(Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b1 - b2, 2) + Math.Pow(c1 - c2, 2)), 2);
Console.WriteLine($"Результат: {l}");