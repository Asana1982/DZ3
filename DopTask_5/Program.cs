//Статистика. Расположение четных и нечетных чисел в разных строчках

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 32); 
Console.WriteLine($"[{string.Join(", ", array)}]");
int countEven = 0, countOdd = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 1)
    {
        Console.Write($"{array[i]} ");
        countEven++;
    }
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
        countOdd++;
    }
}
Console.WriteLine();
if (countEven <= countOdd)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");