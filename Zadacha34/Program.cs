//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]

Console.WriteLine($"[{string.Join(", ", array)}]");
int count = 0;
for (int i = 0; i < array.Length; i++)
if ((array[i] % 2) == 0)
{
    count++;
}
Console.WriteLine($"Результат: [{string.Join(", ", count)}]");