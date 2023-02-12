// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число для определения третьего числа в численном ряду: ");

int number = Convert.ToInt32(System.Console.ReadLine());

if (number > 99)
{

while (number > 1000)
{
    number = number / 10;
}

int numberA = number % 10;
System.Console.WriteLine(numberA);

}
 else
{
    System.Console.WriteLine("Третьей цифры нет");
    }