// Задача 6: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int number = new Random().Next(1, 10);

if(number % 2 == 0)
{
    Console.WriteLine("Число " + number + " четное");
}

else
{
    Console.WriteLine("Число " + number + " не четное");
}
