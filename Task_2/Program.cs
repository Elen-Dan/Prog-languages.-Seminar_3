/*
Задача 2.
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

Console.Clear();

Double Distance = 0; //Определяем переменную расстояния между двумя точками

//Вводим координаты первой точки:
Console.WriteLine("Введите координату первой точки по оси X: ");
string? X1 = Console.ReadLine();

Console.WriteLine("Введите координату первой точки по оси Y: ");
string? Y1 = Console.ReadLine();

Console.WriteLine("Введите координату первой точки по оси Z: ");
string? Z1 = Console.ReadLine();

//Вводим координаты второй точки:
Console.WriteLine("Введите координату второй точки по оси X: ");
string? X2 = Console.ReadLine();

Console.WriteLine("Введите координату второй точки по оси Y: ");
string? Y2 = Console.ReadLine();

Console.WriteLine("Введите координату второй точки по оси Z: ");
string? Z2 = Console.ReadLine();

//Определяем абсолютные значения введенных координат: 
Double tX1 = Math.Abs(Convert.ToDouble(X1));
Double tY1 = Math.Abs(Convert.ToDouble(Y1));
Double tZ1 = Math.Abs(Convert.ToDouble(Z1));
Double tX2 = Math.Abs(Convert.ToDouble(X2));
Double tY2 = Math.Abs(Convert.ToDouble(Y2));
Double tZ2 = Math.Abs(Convert.ToDouble(Z2));

//вычисляем расстояние между двумя точками:
Distance = Math.Sqrt(Math.Pow((tX2-tX1), 2) + Math.Pow((tY2-tY1), 2) + Math.Pow((tZ2-tZ1), 2));
               
 Console.WriteLine("Расстояние между точками равно: " + Distance);              



