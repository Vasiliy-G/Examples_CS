// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25. 2 -> 1,4 

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;

// while(count <= number)
// {
//     double result = Math.Pow(count, 2);
//     Console.WriteLine(result);
//     count++;
    
// }

for (int count = 1; count <= number; count++)
{
    double result = Math.Pow(count, 2);
    Console.WriteLine(result);
}




