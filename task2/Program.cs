/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите число 1: ");
int userNumbera = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int userNumberb = Convert.ToInt32(Console.ReadLine());

if (userNumbera > userNumberb)
{
    Console.WriteLine($"max = {userNumbera}");
    Console.WriteLine($"min = {userNumberb}");
}

else
{
    Console.WriteLine($"max = {userNumberb}");
    Console.WriteLine($"min = {userNumbera}");
}

if (userNumbera == userNumberb)
{
    Console.WriteLine("Ошибка. Введены одинаковые числа.");
}
