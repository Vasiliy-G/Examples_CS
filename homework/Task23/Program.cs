// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void MethodOne(int number)
{
    int count = 1;
    while(count <= number)
    {
        double result = Math.Pow(count, 3);
        Console.WriteLine(result);
        count++;
    }
}


void MethodTwo(int number)
{
    for (int count = 1; count <= number; count++)
    {
        double result = Math.Pow(count, 3);
        Console.WriteLine(result);
    }
}


Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Решение способом №1:");
MethodOne(number);

Console.WriteLine("Решение способом №2:");
MethodTwo(number);
