// 7. Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает последнюю цифру этого числа. 



int num = new Random().Next(100, 1000);

// int num1 = num / 10; //первое число от num
// int num2 = num / 100; //второе число от num
int num3 = num % 10; //последнее число от num

Console.WriteLine(num);
// Console.WriteLine(num1);
// Console.WriteLine(num2);
Console.WriteLine(num3);


