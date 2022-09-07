// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void PrintArray(string [] array)
{
    if (array.Length == 4)
    {
        string [] names = {"b1", "k1", "b2", "k2"};
        Console.Write($"{names[0]} = {array[0]}");

        for (int i = 1; i < array.Length; i++)
        {
            Console.Write($", {names[i]} = {array[i]}");
        }
    }

    else
    {
        Console.WriteLine("Ошибка ввода! Значений должно быть четыре...");
        Environment.Exit(0);
    }

}


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


void intersectionPoint(string [] numbersArray)
{
    double b1 = Convert.ToDouble(numbersArray[0]);
    double k1 = Convert.ToDouble(numbersArray[1]);
    double b2 = Convert.ToDouble(numbersArray[2]);
    double k2 = Convert.ToDouble(numbersArray[3]);

    if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine($" -> Прямые совпадают...");
    }

    else if (k1 == k2)
    {
        Console.WriteLine($" -> Прямые параллельны...");
    }

    else
    {
        double x = (b2-b1)/(k1-k2);
        //double y = k1 * x + b1;
        double y = (k1*(b2-b1))/(k1-k2)+b1;

        Console.WriteLine($" -> ({x}; {y})");
    }
}


Console.WriteLine("Для нахождения точки пересечения двух прямых," +
"\nзаданных уравнениями y = k1 * x + b1, y = k2 * x + b2" +
"\nвведите значения b1, k1, b2 и k2, разделенне пробелом (например: 2 5 4 9)");

string numbers = Console.ReadLine();
string [] numbersArray = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

if (checkDigit(numbersArray))
{   
    PrintArray(numbersArray);
    intersectionPoint(numbersArray);
}

else
{
    Console.WriteLine("\nОшибка ввода! Обнаружены недопустимые символы...");
}
