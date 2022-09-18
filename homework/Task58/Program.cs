// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void PrintMatrix(int [,] matrix1, int [,] matrix2)
{
    Console.WriteLine("Задана матрица № 1:");
    PrintArray(matrix1);
    Console.WriteLine("\nЗадана матрица № 2:");
    PrintArray(matrix2);
}


int [,] FillArray(int [,] array)
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


void PrintArray(int [,] array)
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


 int [,] CreateArray()
{
    int rows = new Random().Next(2, 4);  // 3 7
    int columns = new Random().Next(2, 4);

    int[,] matrix = new int [rows, columns];

    FillArray(matrix);

    return matrix;
}


int[,] ProductTwoMatrix(int[,] matrix1, int[,] matrix2)
{       
    int [,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix3[i, j] = 0;

            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return matrix3;
}


int [,] matrix1 = CreateArray();
int [,] matrix2 = CreateArray();


// Если количество столбцов (columns) первой матрицы 
// не равно количеству строк (row) второй матрицы
while (matrix1.GetLength(1) != matrix2.GetLength(0))
{   
    PrintMatrix(matrix1, matrix2);

    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"\n[!] Error: The number of columns of the first matrix does not equal the number of rows of the second matrix!");
    Console.WriteLine("\n[-] Multiplication is not possible.");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("[.]  Recreate...\n");  
    Console.ResetColor();

    matrix1 = CreateArray();
    matrix2 = CreateArray();
}

PrintMatrix(matrix1, matrix2);

Console.WriteLine("\n[+] Результирующая матрица:");
PrintArray(ProductTwoMatrix(matrix1, matrix2));
