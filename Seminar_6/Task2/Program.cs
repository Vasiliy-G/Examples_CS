// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины. 
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. 


Console.WriteLine("Введите стороны треугольника(a,b,c): "); 
double number1 = Convert.ToDouble(Console.ReadLine()); 
double number2 = Convert.ToDouble(Console.ReadLine()); 
double number3 = Convert.ToDouble(Console.ReadLine()); 

void CheckTriangle(double a,double b,double c)
{
	if( a < b + c && b < c + a && c < a + b) 
	{
		Console.WriteLine("треугольник со сторонами такой длины может существовать."); 
	}
	else
	{
		Console.WriteLine("такой треугольник не существует");
	}
}


CheckTriangle(number1,number2,number3); 
