// // Задача 39: Напишите программу, 
// //которая перевернёт одномерный массив (последний элемент будет на первом месте,
// // а первый - на последнем и т.д.)
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]

// int[] array = GetRandomArray(12,0,100);
// Console.WriteLine($"[{String.Join(",", array)}]");
// // Array.Reverse(array); // простой способ
// // array = MyReverse1(array);// здесь используем свой модуль
// MyReverse2(array);// здесь используем свой модуль другой
// Console.WriteLine($"[{String.Join(",", array)}]");


// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }

//     return result;
// }

// int[] MyReverse1(int[] array)
// {
//     int[] reverse = new int[array.Length];

//     for (int i = 0; i < array.Length; i++)
//     {
//         reverse[i] = array[array.Length - 1 - i];
//     }

//     return reverse;
// }

// void MyReverse2(int[] array)
// {
    
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         int tmp = array[i];
//         array[i] = array[array.Length -1-i];
//         array[array.Length -1-i] = tmp;
        
//     }

   
// }


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли
//  существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух 
// других сторон.

// int[] array = new int [3];

// for (int i =0; i<3; i++)
// {
//     Console.Write("Enter num: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());

// }

// bool CheckTriangle (int[] array)
// {
//     bool result = true;
//     for (int i = 0; i <3; i++)
//     {
//         result &= array[i] < array[(i+1)%3] + array[(i+2) % 3];

//     }
//     return result;
// }
// string msg = CheckTriangle (array) ? "Треугольник реален" : "Треугольник не реален";
// Console.WriteLine(msg);

//  // Второй вариант в одну строку часть кода

// Console.Write("Введите птри чисел (разделитель пробел): ");

// int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

// bool CheckTriangle (int[] array)
// {
//     bool result = true;
//     for (int i = 0; i <3; i++)
//     {
//         result &= array[i] < array[(i+1)%3] + array[(i+2) % 3];

//     }
//     return result;
// }
// string msg = CheckTriangle (array) ? "Треугольник реален" : "Треугольник не реален";
// Console.WriteLine(msg);

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.Write("Введите основание системы счисления: ");
// int @base = int.Parse(Console.ReadLine());
// Console.WriteLine(GetChangeBase(num, @base));

// string GetChangeBase (int num, int @base)
// {
//     int[] array = new int[32];
//     for (int i = 31;;i--)
//     {
//         array[i]=num % @base;
//         num/= @base;
//         if (num ==0) break;
//     }
//     return String.Join("",array);

// }

//Универсальный математический для перевода из 10 в любую
// Console.Clear();
// int number=int.Parse(Console.ReadLine());

// string res1=Convert.ToString(number,2);
// string res2=DecToNum(number,2);

// Console.WriteLine($"{number}->{res1}");
// Console.WriteLine($"{number}->{res2}");


// string DecToNum(int decNumber, int otherSystem)
// {
//     string res="";
//     string nums="0123456789ABCDEF";
//     while(decNumber>0)
//     {
//         int ost=decNumber/otherSystem;
//         res=nums[decNumber-(otherSystem*ost)]+res;
//         decNumber/=otherSystem;
//     }
//     return res;
// }






