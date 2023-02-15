// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число:  ");
string Numbers = Console.ReadLine();
int arg = 0;

for (int i = 0; i < Numbers.Length / 2; i++)
{   
    if (Numbers.Substring(i, 1) != (Numbers.Substring(Numbers.Length - 1 - i, 1)))
    {
        Console.WriteLine("Число не является палиндромом", Numbers);
        break;
    }
    else
    arg = 1;
}
if (arg == 1)
Console.WriteLine("Число является палиндромом", Numbers);
