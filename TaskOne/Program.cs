// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine() ?? "0");

int copy = number;
int numberTwo = 0;
while(copy > 0)
{
    numberTwo = numberTwo * 10 + copy % 10;
    copy = copy / 10;
}
if(number == numberTwo)
    Console.WriteLine("Это число является палиндромом");
else
    Console.WriteLine("Это число не является палиндромом");