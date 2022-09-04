// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 
// 4 -> 24
// 5 -> 120 


int NumSumWhile(int number)
{
    int result = 1;
    int count = 0;

    while(number > count)
    {
        count++;
        result *= count;
    }

    return result;
}


int NumSumFor(int number)
{
    int result = 1;
    
    for(int i = 1; i <= number; i++)
    {
        result *= i;
    }

    return result;
}


Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num + " -> " + NumSumWhile(num));
Console.WriteLine(num + " -> " + NumSumFor(num));
