// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int RandomInterval(int start, int end)
{
    return new Random().Next(start, end);
}


void ArrayFill(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = RandomInterval(-100, 101);
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


int SumOddElements1(int[] array)  // поиск суммы элементов, стоящих на нечётных позициях  вариант 1
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {   
        result += array[i];
    }
    return result;
}


int SumOddElements2(int[] array)  // поиск суммы элементов, стоящих на нечётных позициях  вариант 2
{   
    int count = 0;
    int result = 0;

    while (count < array.Length)
    {   
        if (count % 2 != 0)
        {
            result += array[count]; 
        }

        count++;
    }
    return result;
}


void ArrayPrint2(int[] array)  // Вывод массива на экран вариант 2
{
    Console.Write($"[{string.Join(", ",  array)}]");
}


int [] array = new int[RandomInterval(5, 11)];


ArrayFill(array);

// Вывод массива на экран и поиск суммы элементов, стоящих на нечётных позициях  вариант 1
ArrayPrint(array);
Console.WriteLine($" -> {SumOddElements1(array)}");

// Вывод массива на экран и поиск суммы элементов, стоящих на нечётных позициях  вариант 2
ArrayPrint2(array);
Console.WriteLine($" -> {SumOddElements2(array)}");
