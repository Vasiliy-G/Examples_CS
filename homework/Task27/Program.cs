// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Вариант решения 1
int SummaDigits1(int number)
{
    string numberStr = Convert.ToString(number);
    int numberStrLen = numberStr.Length;
    int numberSum = 0;

    for(int i = 0; i < numberStrLen; i++)
    {
        string numberStrIndex = Convert.ToString(numberStr[i]);
        numberSum = numberSum + Convert.ToInt32(numberStrIndex);
    }

    return numberSum;
}


// Вариант решения 2
int SummaDigits2(int number)
{
    int numberStrLen = Convert.ToString(number).Length;
    int numberDivisor = Convert.ToInt32(Math.Pow(10, numberStrLen - 1));
    int numberSum = number / numberDivisor;

    for(int count = 1; count < numberStrLen; count++)
    {
        int numberDivisor2 = Convert.ToInt32(Math.Pow(10, count));
        int numberDigit = (number / (numberDivisor / numberDivisor2)) % 10;
        numberSum += numberDigit;
    }

    return numberSum;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SummaDigits1(number));
Console.WriteLine(SummaDigits2(number));
