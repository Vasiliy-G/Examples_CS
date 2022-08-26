// Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//int number = new Random().Next(1, 100000);
Console.Write("Введите число: ");
string strInput = Console.ReadLine();

if(strInput.Length <= 2)
{
    Console.WriteLine($"В числе {strInput} нет третей цифры.");
}

else
{
    Console.WriteLine($"Третья цифра числа {strInput} = {strInput[2]}");
}

