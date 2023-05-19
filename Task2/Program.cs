// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
double Sum(double x)
{   double sum = 0;

    while (x > 0)
    {   
        sum = x % 10 + sum;
        x = Math.Floor(x / 10);
    }
    return sum;
}
double sum = Sum(x);
Console.WriteLine($"{x} -> {sum}");