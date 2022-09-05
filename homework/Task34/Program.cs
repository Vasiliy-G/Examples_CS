// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void ArrayRandom(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(100, 1000); 
    }
}


void ArrayPrint(int[] array)  // Вывод массива на экран вариант 1
{
    Console.Write("[");
    
    for(int index = 0; index < array.Length; index++)
    {
        Console.Write(array[index]);
        if(index != array.Length - 1)
        {
            Console.Write(", ");
        }
    }

    Console.Write("]");
}


int CountEvenNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result ++;
    }
    return result;
}


void ArrayPrint2(int[] array)  // Вывод массива на экран вариант 2
{
    Console.Write($"[{string.Join(", ",  array)}]");
}


int [] array = new int[new Random().Next(5, 11)];

ArrayRandom(array);

// Вывод массива на экран вариант 1
ArrayPrint(array);
Console.WriteLine($" -> {CountEvenNumbers(array)}");

// Вывод массива на экран вариант 2
ArrayPrint2(array);
Console.WriteLine($" -> {CountEvenNumbers(array)}");
