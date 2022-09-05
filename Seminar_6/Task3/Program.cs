// Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// 45 -> 101101 
// 3 -> 11 
// 2 -> 10 


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string result = Convert.ToString(num, 2);

// Console.WriteLine($"binary: {result}");


void ConvertNum(int number)
{
    string resalt = "";
    while(number > 0)
    {
        resalt = number %2 + resalt;
        number /= 2;
    }

    Console.WriteLine(resalt);
}


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
ConvertNum(num);
