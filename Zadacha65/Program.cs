// Задача 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string rec(int n, int i)

{
    if (i == n)
        return $"{n}";
    return rec(n, i - 1) + $", {i}";
}

Console.Clear();
Console.Write("Введите число M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, i));
