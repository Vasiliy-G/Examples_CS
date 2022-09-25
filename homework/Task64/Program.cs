// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


int NumberInput(string input)
{
    Console.Write(input);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


string NumbersNutural (int start, int end)
{
    string result = start <= end ? $"{start} " + NumbersNutural(start + 1, end) : string.Empty;
    return result;
}


int M = NumberInput("Задайте значения M: ");
int N = NumberInput("Задайте значения N: ");

if(M == 0 || N == 0 || M > N)
{
    Console.WriteLine("Ошибка ввода данных..."); 
}
else
{
    Console.WriteLine(NumbersNutural(M,N));
}
