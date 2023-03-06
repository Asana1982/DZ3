// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите нужное кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine()),count = 0;
for (int i = 0; i < n; i++)
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
	    count ++;
}	
Console.WriteLine($"Количество положительных чисел: {count}");