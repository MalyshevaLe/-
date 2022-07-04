/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Console.Write("Введите трехзначное число: ");
int nTake = Convert.ToInt32 (Console.ReadLine());
int ShowSecondNum (int num)
{
   int num1 = (num % 100)/10;
   return num1;
}
Console.WriteLine(ShowSecondNum(nTake));*/


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

Console.Write("Введите число: ");
string num = Console.ReadLine();
string ShowThirdNum(){

    if (num.Length > 2){
       return "третья цифра заданного числа " + num[2];
    }
    else{
       return "Третьей цифры нет";
    }
}
Console.WriteLine(ShowThirdNum());*/


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

Console.Write("Введите число от 1 до 7: ");
int dayOfWeek=Convert.ToInt32(Console.ReadLine());
string day() {
    if (dayOfWeek >= 6 && dayOfWeek <=7){
         return "Сегодня выходной)))";
    }
    if (dayOfWeek >=1 && dayOfWeek <= 5){
         return "Сегодня не выходной ((( Работа ждет";
    }
    else {
         return "Нет такого дня недели";
         }
}         
Console.WriteLine(day());*/
