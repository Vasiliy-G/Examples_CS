// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


bool checkDigit(string [] array)
{
    int error = 0;
    for (int i = 0; i < array.Length; i++)
    {
        foreach (char symbol in array[i])
        {
            if (symbol == Convert.ToChar(".") || symbol == Convert.ToChar("-") || Char.IsDigit(symbol) == true){}
            else error++;
        }
    }

    if (error > 0) return false;
    else return true;
}


double numberCount(string [] numbersArray)
{
    int count = 0;

    for (int i = 0; i < numbersArray.Length; i++)
    {
        if(Convert.ToDouble(numbersArray[i]) > 0) count++;
    }

    return count;
}


Console.WriteLine("Введите несколько чисел, разделенных пробелом (например: 0 7.8 -2 -5.5)");
string numbers = Console.ReadLine();

string [] numbersArray = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

Console.Write($"[{string.Join(", ", numbersArray)}]");

if (checkDigit(numbersArray))
{
    Console.WriteLine($" -> {numberCount(numbersArray)}");
}

else
{
    Console.WriteLine("\nОшибка ввода! Обнаружены недопустимые символы...");
}
