// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
    Console.WriteLine($"Создан двухмерный массив {array.GetLength(0)} x {array.GetLength(1)}:\n");

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t ");
        }
        Console.WriteLine();
    }
}


double [] ArithmeticAverage(double [,] matrix)
{
    double [] result = new double [matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i =0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        result[j] = Math.Round(sum / matrix.GetLength(0), 2);
    }
    return result;
}


int rows = new Random().Next(3, 7);
int columns = new Random().Next(3, 7);
double[,] matrix = new double [rows, columns];

FillArray(matrix);

PrintArray(matrix);

Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", ArithmeticAverage(matrix))}");
