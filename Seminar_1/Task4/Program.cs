// 5. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от - N до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int numberNeg = number * (-1);

while(numberNeg<=number)
{
    Console.WriteLine(numberNeg);
    numberNeg++;
}
