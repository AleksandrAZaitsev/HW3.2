// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзначное число: ");

int number = Convert.ToInt32(System.Console.ReadLine());

if (number < 0)
{
   number = -number; 
}

if (number > 99 && number < 1000)
{
    int center = number / 10 % 10;
    Console.WriteLine(center);
}

