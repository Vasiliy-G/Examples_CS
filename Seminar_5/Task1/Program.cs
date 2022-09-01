// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20. 

int [] array = new int [12];
int size = array.Length;
int positiveSum = 0;
int negativeSum = 0;

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-9, 10);

if(array[i] > 0)
    {
        positiveSum += array[i];
    }

    else
    {
        negativeSum += array[i];
    }
}

Console.WriteLine("Сумма положительных чисел = " + positiveSum);
Console.WriteLine("Сумма отрицательных чисел = " + negativeSum);
Console.WriteLine(String.Join("; ", array));
