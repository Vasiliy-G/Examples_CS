// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами 
// в случайном порядке. [1,0,1,1,0,1,0,0] 


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;        
    }

}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}


int [] array = new int[8];  // создать новый массив, в котором будет 8 элементов


FillArray(array); // заполнение массива
PrintArray(array); // вывод на экран массива

Console.WriteLine("");
Console.WriteLine($"[{string.Join(",",  array)}]");

















