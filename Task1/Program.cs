﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int Stepen(int a, int b)
{
    int s = a;
    for (int i = 0; i < b-1; i++)
    {
        s = a*s;
    }
    return s;
}
int s = Stepen(a, b);
Console.WriteLine($"{a}, {b} -> {s}");