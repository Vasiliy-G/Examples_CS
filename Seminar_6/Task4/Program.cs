﻿// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1. 
// Если N = 5 -> 0 1 1 2 3 
// Если N = 3 -> 0 1 1 
// Если N = 7 -> 0 1 1 2 3 5 8 

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int firstN = 0;
int secondN = 1;
Console.Write(firstN + " " + secondN);

for (int i = 3; i <= num; i++)
{
    int newN = firstN + secondN;
    Console.Write( " " + newN);
    firstN = secondN;
    secondN = newN;
}
