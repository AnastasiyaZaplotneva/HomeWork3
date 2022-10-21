// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.WriteLine("Введите координату x первой точки" ?? "0");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки" ?? "0");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки" ?? "0");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки" ?? "0");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки" ?? "0");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z третьей точки" ?? "0");
int z2 = int.Parse(Console.ReadLine());


double distanse = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"Расстояние между точками с заданными координатами равно {distanse}");
