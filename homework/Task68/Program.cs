// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int NumberInput(string input)
{
    Console.Write(input);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int DefAckermann (int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m != 0) return DefAckermann(m - 1, 1);
    else return DefAckermann(m - 1, DefAckermann(m, n - 1));
}


int m = NumberInput("Задайте значения m: ");
int n = NumberInput("Задайте значения n: ");

if(m < 0 || n < 0)
{
    Console.WriteLine("Ошибка ввода данных!"); 
}
else
{
    Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {DefAckermann(m, n)}");
}
