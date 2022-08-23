// 0. Напишите программу, которая на вход принимает число
// и выдает его квадрат (число умноженное на само себя).

//int number = 5;
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sqr = number * number;

Console.WriteLine(sqr);
