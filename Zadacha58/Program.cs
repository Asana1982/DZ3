﻿// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 51); 
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
            Console.WriteLine();
    }
}

int[,] ReleaseMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
{
    int[,] result = new int[FirstMatrix.GetLength(0), FirstMatrix.GetLength(1)];
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
            result[i, j] = FirstMatrix[i, j] * SecondMatrix[i, j];
    }
    return result;
}

Console.Clear();
Console.Write("Введите размер двух матриц: "); 
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] FirstMatrix = new int[size[0], size[1]];
int[,] SecondMatrix = new int[size[0], size[1]];
InputMatrix(FirstMatrix);
InputMatrix(SecondMatrix);
Console.WriteLine("Первый массив: ");
PrintMatrix(FirstMatrix);
Console.WriteLine("Второй массив: ");
PrintMatrix(SecondMatrix);
Console.WriteLine("Результирующая матрица:");
PrintMatrix(ReleaseMatrix(FirstMatrix, SecondMatrix));