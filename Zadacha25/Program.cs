//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int n = Convert.ToInt32(Console.ReadLine());
int j = 1;
for (int i = 1; i <= n; i++)
{
    j = j * num; 
}
Console.WriteLine(j);
