// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day <=7)
{
    switch (day){
   case 1:{
       System.Console.WriteLine("Рабочий");
       break;
   }
   case 2:{
       System.Console.WriteLine("Рабочий");
       break;
   }
   case 3:{
       System.Console.WriteLine("Рабочий");
       break;
   }
   case 4:{
       System.Console.WriteLine("Рабочий");
       break;
   }
   case 5:{
       System.Console.WriteLine("Рабочий");
       break;
   }
   case 6:{
       System.Console.WriteLine("Выходной");
       break;
   }
   case 7:{
       System.Console.WriteLine("Выходной");
       break;
   }
   default:
   {
       System.Console.WriteLine("Такого дня недели нет");
       break;
   }
}
}
else
{
    System.Console.WriteLine("Вы ввели не существующий номер дня недели");
}