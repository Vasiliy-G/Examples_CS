// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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


int [] PositionsInput(double [,] matrix)
{
    Console.Write("\nВведите позицию №1 элемента в массиве (строки): ");
    int rowsInput = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите позицию №2 элемента в массиве (столбцы): ");
    int columnsInput = Convert.ToInt32(Console.ReadLine());


    if (rowsInput > matrix.GetLength(0) - 1 || columnsInput > matrix.GetLength(1) - 1)
    {
        Console.WriteLine($"\n{rowsInput}, {columnsInput} -> Числа с такой позицией в массиве нет!");
        Console.WriteLine("Повторите ввод.\n");
        Environment.Exit(0);
    }

    return new int[] {rowsInput, columnsInput};
}


void SearchPosition(double [,] array, int [] position)
{
    var element = array[position[0], position[1]];
    Console.WriteLine($"На позиции {position[0]}, {position[1]} находится элемент: {element}");
}


int rows = new Random().Next(3, 7);
int columns = new Random().Next(3, 7);
double[,] matrix = new double [rows, columns];

FillArray(matrix);

PrintArray(matrix);

SearchPosition(matrix, PositionsInput(matrix));
