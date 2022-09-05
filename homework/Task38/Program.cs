// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void ArrayFill(double[] array)  // заполнение массива целыми числами
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(1, 101);
    }
}


void ArrayFill2(double[] array)   // заполнение массива дробными числами
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = Convert.ToDouble(new Random().Next(-1000, 1000)/10.0);
    }
}


double DifferenceMinMax(double [] array)
{
    double min = array[0];
    double max = array[0];

    for(int i = 1; i < array.Length; i++)
    {
        if (min < array[i]) min = min;
        else min = array[i];
        
        if (max > array[i]) max = max;
        else max = array[i];
    }

    return max - min;
   }


double [] array = new double[new Random().Next(5, 11)];

ArrayFill(array);  // заполнение массива целыми числами
Console.Write($"[{string.Join(", ",  array)}]");
Console.WriteLine(" -> " + DifferenceMinMax(array));

ArrayFill2(array);  // заполнение массива дробными числами
Console.Write($"[{string.Join(", ",  array)}]");
Console.WriteLine(" -> " + Math.Round(DifferenceMinMax(array), 2));
