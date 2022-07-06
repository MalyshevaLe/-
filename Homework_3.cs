/*Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

Console.Write("Введите пятизначное число: ");
string number=Console.ReadLine();
string ChekingPalindrome(){
    if (number.Length == 5){
        if (number[0] == number[4] && number[1] == number[3]){
            return "Введенное Вами число - палиндром :-)";
        }
        else {
           return "Введенное Вами число - не палиндром!!!"; 
        }
    }
    else {
        return"Неверный формат числа. Введите пятизначное число и попробуйте снова";
    }
}
Console.WriteLine(ChekingPalindrome());*/

/*Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.Write("x1= ");
int A1=Convert.ToInt32(Console.ReadLine());
Console.Write("y1= ");
int A2=Convert.ToInt32(Console.ReadLine());
Console.Write("z1= ");
int A3=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("x2= ");
int B1=Convert.ToInt32(Console.ReadLine());
Console.Write("y2= ");
int B2=Convert.ToInt32(Console.ReadLine());
Console.Write("z2= ");
int B3=Convert.ToInt32(Console.ReadLine());

string Distance (int x1, int y1, int z1, int x2, int y2, int z2){
    double dis=Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
    return string.Format("{0:0.##}", dis);  //вывод числа с двумя знаками после запятой
}

Console.WriteLine(Distance(A1,A2,A3,B1,B2,B3));*/


/*Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите число: ");
int number=Convert.ToInt32(Console.ReadLine());

int Cube(int num)
{
    for (int i=1; i <=num; i++)
    {
        Console.Write(Math.Pow(i, 3) + "|");
    }
    return num;
}

Cube(number);
