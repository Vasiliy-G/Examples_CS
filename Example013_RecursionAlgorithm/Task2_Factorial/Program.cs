// Факториал 5! = 5 * 4 * 3 * 2 * 1


double Factorial(int n)
{
    // 1! = 1
    // 0! = !
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}


Console.WriteLine(Factorial(3));  // 1 * 2 * 3 = 6

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
