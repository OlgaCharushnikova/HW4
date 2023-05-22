// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите количество элементов массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] array = new int [l];

for (int i = 0; i < l; i++)
    {
     array[i] = new Random().Next(1, 100);
     Console.Write($"{array[i]} ");
    } 

