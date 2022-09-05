// Двумерные массивы


void PrintArrayTable(string[,] table)
{
    for (int rows = 0; rows < 2; rows++)
    {
        for (int columns = 0; columns < 5; columns++)
        {
            Console.WriteLine($"-{table[rows, columns]}-");
        }
    }
}


// String.Empty
string[,] table = new string[2, 5];  // 2 строки, 5 столбцы
table[1, 2] = "слово";
PrintArrayTable(table);


void PrintArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)  // matrix.GetLength(0) длинна строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // matrix.GetLength(1) длинна столбцов
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}


void FillArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)  // matrix.GetLength(0) длинна строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // matrix.GetLength(1) длинна столбцов
        {
           matrix[i ,j] = new Random().Next(1, 10);  // [1; 10)]
        }
    }
}


int[,] matrix = new int[3, 4];  // 3 строки, 4 столбцы

PrintArrayMatrix(matrix);
FillArrayMatrix(matrix);
Console.WriteLine();
PrintArrayMatrix(matrix);
