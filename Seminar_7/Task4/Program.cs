// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. 


Console.Write("Введите количество строк(rows): ");
int rows = int.Parse(Console.ReadLine());  // Второй способ конвертации в int

Console.Write("Введите количество столбцов(columns): ");
int columns = Convert.ToInt32(Console.ReadLine());  // Первый способ конвертации в int

int[,] matrix = new int [rows, columns];
int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 11);
        if (i ==j)
        {
            sum += matrix[i, j];
        }

        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
        
}

Console.WriteLine($"Сумма = {sum}");
