// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

int number1 = new Random().Next(10, 100);
//int number1 = 81;
Console.WriteLine(number1);

int number2 = new Random().Next(10, 100);
//int number2 = 9;
Console.WriteLine(number2);

if(number1 * number1 == number2 || number2 * number2 == number1)
{
    Console.WriteLine("Является");
}

else
{
     Console.WriteLine("Не является");
}
