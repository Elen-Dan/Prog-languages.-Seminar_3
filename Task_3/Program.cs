/*
Задача 3.
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear();

Console.WriteLine("Введите число для возведения в степень 3");

string? Number = Console.ReadLine();
Console.WriteLine("");
int tempN = Convert.ToInt32(Number); // временная переменная для конвертации

for (int i = 1; i !<= tempN; i=i+1)
    Console.WriteLine(Math.Pow(i, 3));
    
