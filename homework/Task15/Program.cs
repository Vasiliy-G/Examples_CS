// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

string [] array = {"Понедельник", "Вторник", "Среда",
                     "Четверг", "Пятница", "Суббота", "Воскресенье"};

int length = array.Length;


for (int i = 0; i < length; i++)
{
    Console.WriteLine(i + 1 + ". " + array[i]);
}

Console.Write("Выберите цифру, обозначающую день недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if(numberDay < 1 || numberDay > 7)
{
     Console.WriteLine("Ошибка! Введите число от 1 до 7");
}

else
{
    if (numberDay == 6 || numberDay == 7)
    {
        Console.WriteLine($"Вы выбрали {array[numberDay - 1]} и это выходной! Ура :)");
    }
    else
    {
        Console.WriteLine($"Вы выбрали {array[numberDay - 1]} и это будний день...");
    }
}
