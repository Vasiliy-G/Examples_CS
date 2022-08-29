// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Вариант решения 1
int GetDegree1(int numberA, int numberB)
{    
    return Convert.ToInt32(Math.Pow(numberA, numberB));
}


// Вариант решения 2
int GetDegree2(int numberA, int numberB)
{   
    int res = 1;

    for(int i = 1; i <= numberB; i++)
    {
        res *= numberA; 
    }

    return res;
}


// Вариант решения 3
int GetDegree3(int numberA, int numberB)
{   
    int res = 1;
    int i = 1;
    
    while(i <= numberB)
    {
        res *= numberA; 
        i++;
    }

    return res;
}


Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(numberA + " ^ " + numberB + " = " + GetDegree1(numberA, numberB));
Console.WriteLine(numberA + " ^ " + numberB + " = " + GetDegree2(numberA, numberB));
Console.WriteLine(numberA + " ^ " + numberB + " = " + GetDegree3(numberA, numberB));
