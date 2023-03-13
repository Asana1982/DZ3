// Задача 63. Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до  N.

string rec(int n)
{
    if (n == 1)
        return "1";
    return rec(n - 1) + $", {n}";
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));