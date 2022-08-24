// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа. 

int num = new Random().Next(100, 1000);
int num1 = num / 100; //первое число от num
int num3 = num % 10; //третье число от num
//int result = num1 * 10 + num3;

Console.WriteLine("Первая и третья цифра: " + num1 + "" + num3 + " от числа " + num);
//Console.WriteLine("Первая и третья цифра: " +  result + " от числа " + num);
