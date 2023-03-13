// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int formula(int m, int n)
{
    if (m == 0)
        return (n + 1);
    else if (m > 0 && n == 0)
        return formula(m - 1, 1);
    else
        return formula(m - 1, formula(m, n - 1));
}

Console.Clear();
Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {formula(m, n)}");