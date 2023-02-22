//Задайте массив целых чисел. Найдите разницу между максимальным
//и минимальным элементом массива

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100); 
Console.WriteLine($"[{string.Join(", ", array)}]");
int max = int.MinValue;
int min = int.MaxValue;
for (int i = 0; i < array.Length; i++)
{

    if (array[i] > max)
    {
            max = array[i];
    }
    if (array[i] < min)
    {
            min = array[i];
    }
}

Console.WriteLine($"Максимальное значение: {max}");
Console.WriteLine($"Минимальное значение: {min}");

Console.WriteLine($"Разница между максимальным и минимальным значениями: {max - min}");