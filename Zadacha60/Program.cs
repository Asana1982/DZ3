// Задача 60. Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 х 2 х 2

void InputMatrix(int[,,] ThreeMatrix)
{
    int number = 5;
    for (int i = 0; i < ThreeMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ThreeMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < ThreeMatrix.GetLength(2); k++)
                ThreeMatrix[i, j, k] = number++; 
        }
    }
}

void PrintMatrix(int[,,] ThreeMatrix)
{
    for (int i = 0; i < ThreeMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ThreeMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < ThreeMatrix.GetLength(2); k++)
                Console.WriteLine($"{ThreeMatrix[i, j, k]} ({i}, {j}, {k})");
        }
    }
}

Console.Clear();
Console.Write("Введите размер трехмерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] ThreeMatrix = new int[size[0], size[1], size[2]];
InputMatrix(ThreeMatrix);
PrintMatrix(ThreeMatrix);