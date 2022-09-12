﻿// Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран. 
// m = 3, n = 4. 0 1 2 3
// 1 2 3 4 
// 2 3 4 5 

Console.Write("Введите количество строк(rows): ");
int rows = int.Parse(Console.ReadLine());  // Второй способ конвертации в int

Console.Write("Введите количество столбцов(columns): ");
int columns = Convert.ToInt32(Console.ReadLine());  // Первый способ конвертации в int


int[,] matrix = new int [rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = i + j;
        Console.Write(matrix[i, j] + "\t");
    }

    Console.WriteLine();
}







