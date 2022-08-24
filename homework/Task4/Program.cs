// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

int number1 = new Random().Next(1, 10);
int number2 = new Random().Next(1, 10);
int number3 = new Random().Next(1, 10);
int max = number1;

Console.WriteLine("Число1 = " + number1);
Console.WriteLine("Число2 = " + number2);
Console.WriteLine("Число3 = " + number3);

if(number2 > max) max = number2;

if(number3 > max) max = number3;

Console.WriteLine("Максимальное число = " + max);
