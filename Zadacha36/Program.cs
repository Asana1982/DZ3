//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 40); 
Console.WriteLine($"[{string.Join(", ", array)}]");
int result = 0;
for (int i = 0; i < array.Length; i++)
if (i % 2 !=0)
{
    result += array[i];
}
Console.WriteLine(result);