// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты. 

Console.Write("Введите количество строк(rows): ");
int rows = int.Parse(Console.ReadLine());  // Второй способ конвертации в int

Console.Write("Введите количество столбцов(columns): ");
int columns = Convert.ToInt32(Console.ReadLine());  // Первый способ конвертации в int

double[,] matrix = new double [rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 11);
        if (i % 2 == 0 && j % 2 == 0)
        {
            matrix[i, j] = Math.Pow(matrix[i, j], 2);
        }

        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
        
}




