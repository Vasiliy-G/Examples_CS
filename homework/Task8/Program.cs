// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//int number = new Random().Next(1, 10);
int count = 0;

Console.WriteLine("Число = " + number);

while (count <= number)
{
    Console.WriteLine(count);
    count +=2;
}


