// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4. 1 4 8 19 5 -2 33 -2 77 3 8 1 

Console.Write("Введите количество строк(rows): ");
int rows = int.Parse(Console.ReadLine());  // Второй способ конвертации в int

Console.Write("Введите количество столбцов(columns): ");
int columns = Convert.ToInt32(Console.ReadLine());  // Первый способ конвертации в int

int[,] matrix = new int [rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j =0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 11);
        Console.Write(matrix[i, j] + "\t ");
    }
    Console.WriteLine();
}



