//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int length = a; 
int sum = 0;
for (int i = 1; i <= length; i++)
{
    sum += a % 10;
    a /=  10;
}
Console.WriteLine(sum);
