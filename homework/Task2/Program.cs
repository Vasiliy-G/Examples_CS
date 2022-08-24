// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

int number1 = new Random().Next(1, 10);
int number2 = new Random().Next(1, 10);

if(number1 > number2)
{
    Console.WriteLine("Число1 = " + number1 + " и оно большее");
    Console.WriteLine("Число2 = " + number2 + " и оно меньшее");
}

if(number1 < number2)
{
    Console.WriteLine("Число1 = " + number1 + " и оно меньшее");
    Console.WriteLine("Число2 = " + number2 + " и оно большее");
}

if(number1 == number2)
{
    Console.WriteLine("Числа " + number1 + " и " + number2 + " равны");
}
