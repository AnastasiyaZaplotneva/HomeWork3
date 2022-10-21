// SНапишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int count = 1;
while(count <= number)
{
    Console.Write($"{Math.Pow(count, 3)}, ");
    count++;
}
