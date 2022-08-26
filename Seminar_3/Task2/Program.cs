// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y). 

Console.WriteLine("Введите номер четверти: ");
int part = Convert.ToInt32(Console.ReadLine());

if (part == 1)
{
    Console.WriteLine("x = [0; +бесконечность]; y = [0; +бесконечность]");
}

else if (part == 2)
{
    Console.WriteLine("x = [0; +бесконечность]; y = [0; -бесконечность]");
}

else if (part == 3)
{
    Console.WriteLine("x = [0; -бесконечность]; y = [0; -бесконечность]");
}

else if (part == 4)
{
    Console.WriteLine("x = [0; -бесконечность]; y = [0; +бесконечность]");
}

else
{
     Console.WriteLine("Введите число от 1 до 4");
}


