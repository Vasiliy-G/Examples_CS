﻿// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100, 1000);
int number2 = (number / 10) % 10;  // вторая цифра трехзначного числа

Console.WriteLine($"Вторая цифра числа {number} = {number2}");