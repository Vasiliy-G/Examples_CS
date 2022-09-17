// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка


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


 double[,] CreateArray()
{
    int rows = new Random().Next(3, 7);  // 3 7
    int columns = new Random().Next(3, 7);
    double[,] matrix = new double [rows, columns];
    return matrix;
}


int [] CountsSumElements(double [,] array)
// считает сумму элементов в каждой строке
{
    int [] sumElements = new int [array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j =0; j < array.GetLength(1); j++)
        {
            sum = sum + Convert.ToInt32(array[i, j]);            
        }
        sumElements[i] = sum;
    }
    return sumElements;
}


int LowestSumElements(int [] array)
// выдаёт номер строки с наименьшей суммой элементов
{   
    Console.WriteLine();
    int sumMin = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"строка: {i + 1}, сумма: {array[i]};");
        if (array[i] < sumMin) sumMin = array[i];
        else sumMin = sumMin;
    }
    int index = Array.IndexOf(array, sumMin);
    return index + 1;
}


double[,] matrix = CreateArray();

while (matrix.GetLength(0) == matrix.GetLength(1))
{   
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"[!] while: {matrix.GetLength(0)} x {matrix.GetLength(1)}");
    Console.WriteLine(" Array is not rectangular, recreate...");
    Console.ResetColor();
    matrix = CreateArray();
}


FillArray(matrix);
Console.WriteLine($"Создан двухмерный прямоугольный массив {matrix.GetLength(0)} x {matrix.GetLength(1)}:");
PrintArray(matrix);
CountsSumElements(matrix);
Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {LowestSumElements(CountsSumElements(matrix))} строка.");
