// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 
// 78 -> 2 
// 89126 -> 5 


int CountNum1(int number)
{
    int size = Convert.ToString(number).Length;
    return size;
}


int CountNum2(int number)
{
    int count =0; 
    while(number>0) 
    {
        count++; 
        number/=10; 
    } 

    return count; 
} 


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Колличество цифр: " + CountNum1(number));
Console.WriteLine("Колличество цифр: " + CountNum2(number));







// string num = Console.ReadLine();

// int CountingDigits(string num) 
// {
//     return num.Length;
// }

// Console.WriteLine(CountingDigits(num));









// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string result = Convert.ToString(num);
// Console.WriteLine("количество цифр="+ KolvoCifr(result) );

// int KolvoCifr (string num) 
// {
//     int size=num.Length;
// }    
 
//     return size; 






// string num = Console.ReadLine();

// int CountingDigits(string num)
// {
//     return num.Length;
// }

// Console.WriteLine(CountingDigits(num)); 





// string num = Console.ReadLine();

// int CountingDigits(string num)
// {
//     return num.Length;
// }

// Console.WriteLine(CountingDigits(num)); 














