/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int userNumberOne = new int();
int userNumberTwo = new int();
int userNumberThree = new int();

Console.WriteLine("Введите число 1: ");
userNumberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
userNumberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
userNumberThree = Convert.ToInt32(Console.ReadLine());

int max = userNumberOne;

if(userNumberTwo > max)
{
    max = userNumberTwo;
}
if(userNumberThree > max)
{
    max = userNumberThree;
}

Console.WriteLine($"Максимальное число равно {max}");