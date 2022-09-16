// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии. 
// A = 3; B = 5 -> 243 (3⁵) 
// A = 2; B = 3 -> 8 


int Exponentiation(int a,int n) 
{
    if(n == 0) return 1;
    return a * Exponentiation(a,n-1);
} 


Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Exponentiation(a, b)); 
