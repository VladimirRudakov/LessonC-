// Урок 1. Знакомство с языком программирования С#
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter number A : ");
string strNumA = Console.ReadLine();

Console.WriteLine("Enter number B : ");
string strNumB = Console.ReadLine();

int numA = Convert.ToInt32(strNumA);
int numB = Convert.ToInt32(strNumB);

if (numA > numB)
{
    Console.WriteLine($"число {numA} > числа {numB}");
}
else
{
    Console.Write($"число {numB} > числа {numA}");
    
}



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter number A : ");
string strNumA = Console.ReadLine();

Console.WriteLine("Enter number B : ");
string strNumB = Console.ReadLine();

Console.WriteLine("Enter number C : ");
string strNumC = Console.ReadLine();

int numA = Convert.ToInt32(strNumA);
int numB = Convert.ToInt32(strNumB);
int numC = Convert.ToInt32(strNumC);

int max = numA;

if (numA > max) max =numA;
if (numB> max) max = numB;
if (numC> max) max = numC;

Console.Write("max = ");
Console.WriteLine(max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Enter number A : ");
string strNumA = Console.ReadLine();

int numA = Convert.ToInt32(strNumA);


if (numA % 2 == 0)
{
    Console.WriteLine($"число {numA} является четным");
}
else
{
    Console.Write($"число {numA} не является четным");
    
}



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Enter number A : ");
string strNumA = Console.ReadLine();

int numA = Convert.ToInt32(strNumA);

int count =0;

 while(count < numA)
 {
    Console.WriteLine(count+1);
    count += 1;

 }