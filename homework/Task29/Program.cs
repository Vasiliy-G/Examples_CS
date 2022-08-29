// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


void ArrayRandom(int[] array)
{
    int arrayLength = array.Length;
    
    for(int index = 0; index < arrayLength; index++)
    {
        array[index] = new Random().Next(0, 101); 
    }
}


void ArrayPrint(int[] array)
{
    int arrayLength = array.Length;
    
    for(int index = 0; index < arrayLength; index++)
    {
        Console.Write(array[index]);
        if(index != arrayLength - 1)
        {
            Console.Write(", ");
        }
    }
}


int [] array = new int[8];

ArrayRandom(array);
ArrayPrint(array);