// Имеется одномерный массив array из n элементов,
// требуется найти элемент массива, равный find

// Создаем массив
// Заполняем массив рандомными значениями от 0 до 9
// Распечатаем массив

// Если метод (функция) ничего не возвращает (return) называется void

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 10);
        index++;        
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    //int position = 0;
    int position = -1;  // если элемент не найден, выдаст -1
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;        
    }
    return position;
    
}


int [] array = new int[10];  // создать новый массив, в котором будет 10 элементов


FillArray(array);
// array[4] = 4;
// array[6] = 4;
PrintArray(array);
Console.WriteLine();

int numFind = 4;

int pos = IndexOf(array, numFind);
Console.WriteLine(pos);