// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int NumberInput(string input)
{
    Console.Write(input);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int NumbersNuturalSum (int start, int end)
{
    int result = start <= end ? start + NumbersNuturalSum(start + 1, end) : 0;
    return result;
}


int M = NumberInput("Задайте значения M: ");
int N = NumberInput("Задайте значения N: ");

if(M == 0 || N == 0 || M >= N)
{
    Console.WriteLine("Ошибка ввода данных!"); 
}
else
{
    Console.WriteLine(NumbersNuturalSum(M,N));
}
