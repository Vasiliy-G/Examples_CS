// 9. Напишите программу, которая выводит случайное число 
// из отрезка[10, 99] и показывает наибольшую цифру числа

int num = new Random().Next(10, 100);
int num1 = num / 10; //первое число от num
int num2 = num % 10; //второе число от num
int max = num1;

if (max < num2) max = num2;

Console.WriteLine("У числа " + num + " наибольшая цифра " + max);
