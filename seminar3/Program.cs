// // Напишите программу, которая принимает на вход координаты точки(x и y)
// // примче x!=0 и y!=0 и выдает номер четвертиплоскости в котороый находится эта точка

// Console.Write("Enter numver X:");
// int numX=int.Parse(Console.ReadLine());

// Console.Write("Enter number y:");
// int numY= int.Parse(Console.ReadLine());

// if (numX>0 && numY>0)
// {
//     Console.WriteLine("Selection 1");

// }
// else if (numX<0 && numY>0)
// {
//     Console.WriteLine("Selection 2");

// }
// else if (numX<0 && numY<0)
// {
//     Console.WriteLine("Selection 3");

// }
// else if (numX>0 && numY<0)
// {
//     Console.WriteLine("Selection 4");

// }

// // Задача 2. Напиши программу которая по заданному номеру четверти показыввет диапазон возможных координат точек в этой четврегти (х и у)

// Console.Write("Enter number section:");
// int numS=int.Parse(Console.ReadLine());


// if (numS==1)
// {
//     Console.WriteLine("x>0 b Y>0");

// }
// else if (numS==2)
// {
//     Console.WriteLine("x<0 b Y>0");

// }
// else if (numS==3)
// {
//     Console.WriteLine("x<0 b Y<0");

// }
// else if (numS==4)
// {
//     Console.WriteLine("x>0 b Y<0");

// }
// else if (numS>4)
// {
//     Console.WriteLine("Такой четсврети нет");

// }

// // Задача 3 На вход будет подаваться число (сумма вклада). При значении меньше 100, 
// // будет начислено 5 %, если значение находится в диапазоне от ста до двухсот — 7 %, 
// // если больше — 10 %. Отработав, программа должна вывести общую сумму с начисленными
// //  процентами. Для решения этой задачи воспользуемся выражением
// //  Convert.ToDouble(Console.ReadLine()), которое нам пригодится для получения
// // вводимого с клавиатуры числа.

// Console.Write("Введите сумму вклада");
// int numSum=int.Parse(Console.ReadLine());
// Convert.ToDouble((numSum));
// // 

// if (numSum<100)
// {
//     double sum=numSum+numSum*0.05;
//     Console.WriteLine(sum);
// }
// else if (numSum>=100 && numSum<200  )
// {
//     double sum=numSum+numSum*0.07;
//     Console.WriteLine(sum);
// }
// else if (numSum>=200)
// {
//     double sum=numSum+numSum*0.10;
//     Console.WriteLine(sum);
// }

// // Задача 4. Напишите программу, которая принимает на вход координаты двух точек и находит
// //  расстояние между ними в 2D пространстве.

// // A (3,6); B (2,1) -> 5,09
// // A (7,-5); B (1,-1) -> 7,21
// // AB = √(xb - xa)2 + (yb - ya)2

// Console.WriteLine("Введите х1");
// int X1=int.Parse(Console.ReadLine());
// Console.WriteLine("Введите х2");
// int X2=int.Parse(Console.ReadLine());
// Console.WriteLine("Введите Y1");
// int Y1=int.Parse(Console.ReadLine());
// Console.WriteLine("Введите Y2");
// int Y2=int.Parse(Console.ReadLine());

// // double Otv=Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1));
// double Otv=Math.Sqrt((Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)));
// Console.WriteLine(Otv);

// // Задача 5 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// // от 1 до N.
// // 5 -> 1, 4, 9, 16, 25.
// // 2 -> 1,4

// Console.WriteLine("Введите число");
// int input1 = int.Parse(Console.ReadLine());

// for (int i =1; i <= input1; i++)
// {
//     Console.Write($" {i*i}");

// }
