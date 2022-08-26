// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void MethodOne(string number)
{
    string numberReverse = "";

    for (int i = number.Length - 1; i >= 0; i--)
    {
        numberReverse = numberReverse + number[i];
    }

    if(number == numberReverse)
        Console.WriteLine($"Число {number} является палиндромом.");
    else
        Console.WriteLine($"Число {number} не является палиндромом.");
}


void MethodTwo(string number)
{
    int length = number.Length;
    int match = 0;

    for (int i = 0; i <  number.Length / 2; ++i)
    {
        if (number[i] == number[number.Length - 1 - i])
        {
            match++;
        }
    }

    if(match == number.Length / 2)
        Console.WriteLine($"Число {number} является палиндромом.");
    else
        Console.WriteLine($"Число {number} не является палиндромом.");
}


Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

if(number.Length != 5)
{
    Console.WriteLine("Необходимо ввести пятизначное число!");
}

else
{
    Console.WriteLine("Решение способом №1:");
    MethodOne(number);

    Console.WriteLine("Решение способом №2:");
    MethodTwo(number);  
}





