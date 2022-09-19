// Задача 62. Напишите программу, которая заполнит спирально 
// массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] FillArraySpiral(int[,] array)
{
    int len = array.GetLength(0), pos = 1, count = len, value = -len, sum = -1;

    while (count > 0)
    {
        value = -1 * value / len;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            array[sum / len, sum % len] = pos++;
        }
        
        value *= len;
        count--;
        
        for (int i = 0; i < count; i++)
        {
            sum += value;
            array[sum / len, sum % len] = pos++;
        }
    } 

    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            string nul = array[i, j] < 10 ?  "0" : "";
            Console.Write(nul + array[i, j] + " ");
        }

        Console.WriteLine();
    }
}


int[,] matrix = new int[4, 4];

FillArraySpiral(matrix);

PrintArray(matrix);
