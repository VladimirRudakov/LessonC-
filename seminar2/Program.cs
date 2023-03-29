// // 1 Задача Напишите программу, которая выводит случайное число из отрезка (10,99) и показывает наибольшую цифру
// int num = new Random().Next(10,100);


// int num1 =num/10;
// int num2 = num % 10;

// System.Console.WriteLine(num);

// if (num1>num2)
// {
//     System.Console.WriteLine($"num1 > num2 max = {num1}");

// }
// else if (num1<num2)
// {
//     System.Console.WriteLine($"num1 < num2 max = {num2}");

// }
// else if (num1==num2)
// {
//     System.Console.WriteLine($"num1 == num2 max = {num2}");

// }

// 2 Задача Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

// int num = new Random().Next(100,1000);
// int num1 =num/100;

// int num3= num%10;

// int num4 = num1 *10 +num3;
// System.Console.WriteLine($"{num},{num4}");

// 3 Нужно написать программу, которая будет принимать на вход два числа и выводить является
//  ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления

// Console.WriteLine("Enter numberА : ");
// string strNum = Console.ReadLine();
// int num = Convert.ToInt32(strNum);

// Console.WriteLine("Enter numberВ : ");
// strNum = Console.ReadLine();
// int num1 = Convert.ToInt32(strNum);

// int diff= num % num1;

//  if (diff ==0)
// {
//     System.Console.WriteLine($"Число{num}   кратно {num1}");

// }
// else if (diff !=0)
// {
//     System.Console.WriteLine($"Число{num}  не кратно {num1}, остаток {diff}");
// }

// 4 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

//  Console.WriteLine("Enter numberА : ");
// string strNum = Console.ReadLine();
// int num = Convert.ToInt32(strNum);

// int diff= num % 7;
// int diff1= num % 23;

//  if (diff+diff1 ==0)
// {
//     System.Console.WriteLine($"Число{num} кратно 7 и 23");

// }
// else if (diff + diff1 !=0)
// {
//     System.Console.WriteLine($"Число{num}  не кратно 7 и 23");
// }

// 5. Напишите программу, которая принимает на вход два числ и проверяет, является ли одно число квадратом другого
Console.WriteLine("Enter numberА : ");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);

Console.WriteLine("Enter numberВ : ");
strNum = Console.ReadLine();
int num1 = Convert.ToInt32(strNum);

int diff =num1*num1;
int diff1 =num*num;

if (num>num1)
{
    if(diff==num)
    {
         System.Console.WriteLine($"Число{num}   является квадратом {num1}");
    }
   

}
if (num<num1)
{
    if(diff1==num1)
    {
         System.Console.WriteLine($"Число{num1}   является квадратом {num}");
    }
   

}
