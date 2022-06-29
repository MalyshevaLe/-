// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.WriteLine("Введите первое число");
int a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b=Convert.ToInt32(Console.ReadLine());
int max=a;

if (a>b) max=a;
else max=b;

Console.Write("max= ");
Console.WriteLine(max);
*/

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.WriteLine("Введите первое число");
int a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int с=Convert.ToInt32(Console.ReadLine());
int max=a;

if (a>max) max=a;
if (b>max) max=b;
if (с>max) max=с;

Console.Write("max= ");
Console.WriteLine(max);
*/


//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) {
    Console.WriteLine("Введенное число является четным"); 
}
else {
    Console.WriteLine("Ошибка!!! Введенное число является нечетным"); 
}
*/


//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int index=1; index <= num; index++)
{
    if (index % 2 == 0)
    {
        Console.Write(index+ ", ");
    }
}

