// // Задача 19

// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// // 14212 -> нет

// // 12821 -> да

// // 23432 -> да

// Console.WriteLine("Введите пятизначное число : ");
// string strNum = Console.ReadLine();
// int num = Convert.ToInt32(strNum);

// int diff1= num % 10;
// int diff2= num % 100;
// int diff3= num % 1000;
// int diff01=num % 100;
// int new1 = diff2;
// Console.WriteLine($"Число{diff01} ={new1}");


//  if (diff01 == new1)
// {
//     Console.WriteLine($"Число{num} является палиндромом");
// }
//  else if (diff01 != new1)
// {
//     Console.WriteLine($"Число{num} не является палиндромом");
// }

// // Задача 21

// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// // между ними в 3D пространстве.

// // A (3,6,8); B (2,1,-7), -> 15.84

// // A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите х1");
// int X1=int.Parse(Console.ReadLine());
// Console.WriteLine("Введите Y1");
// int Y1=int.Parse(Console.ReadLine());
// Console.WriteLine("Введите Z1");
// int Z1=int.Parse(Console.ReadLine());

// Console.WriteLine("Введите х2");
// int X2=int.Parse(Console.ReadLine());
// Console.WriteLine("Введите Y2");
// int Y2=int.Parse(Console.ReadLine());
// Console.WriteLine("Введите Y2");
// int Z2=int.Parse(Console.ReadLine());

// double Otv=Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2) +Math.Pow((Z2-Z1),2));
// Console.WriteLine(Otv);

// // Задача 23

// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число");
// int input1 = int.Parse(Console.ReadLine());

// for (int i =1; i <= input1; i++)
// {
//     Console.Write($" {i*i*i}");

// }
