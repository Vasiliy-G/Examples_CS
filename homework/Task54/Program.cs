// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


double [,] FillArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}


void PrintArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t ");
        }
        Console.WriteLine();
    }
}


double [,] RowsElementDecreaseArray(double [,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    double temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }                      
        }

    }
    return array;
}


int rows = new Random().Next(3, 7);
int columns = new Random().Next(3, 7);
double[,] matrix = new double [rows, columns];

FillArray(matrix);
Console.WriteLine($"Создан двухмерный массив {matrix.GetLength(0)} x {matrix.GetLength(1)}:");
PrintArray(matrix);
Console.WriteLine($"\nСоздан новый двухмерный массив {matrix.GetLength(0)} x {matrix.GetLength(1)}:");
PrintArray(RowsElementDecreaseArray(matrix));