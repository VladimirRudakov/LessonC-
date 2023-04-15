﻿// //HW
// Start();

// void Start()
// {

//     while (true)
//     {
//         Console.ReadLine();
//         Console.Clear();

//         System.Console.WriteLine("34) Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
//         System.Console.WriteLine("36) Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
//         System.Console.WriteLine("38) Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
//         System.Console.WriteLine("0) End");

//         int numTask = SetNumber("task");

//         switch (numTask)
//         {
//             case 0: return; break;

//             case 34:
//                 Console.Clear();
//                 int[] startArray = GetArray(12, 100, 999);
//                 Console.WriteLine(String.Join(" ", startArray));
//                 Console.WriteLine($"Количество четных элементов в массиве = {GetEvenCount(startArray)}");
//                 break;
//             case 36:
//                 Console.Clear();
//                 startArray = GetArray(6, 0, 999);
//                 Console.WriteLine(String.Join(" ", startArray));
//                 Console.WriteLine($"Сумма элементов на нечетных позициях = {GetSumOdd(startArray)}");

//                 break;


//             case 38:
//                 Console.Clear();
//                 double[] startArrayDouble = GetArrayDouble(6, 0, 999);
//                 Console.WriteLine(String.Join(" ", startArrayDouble));
//                 Console.WriteLine($"Разница = {GetDifference(startArrayDouble)}");
//                 break;
//             default: System.Console.WriteLine("error"); break;
//         }
//     }
// }

// int SetNumber(string numberName)
// {
//     Console.Write($"Enter number {numberName}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// double[] GetArrayDouble(int size, int minValue, int maxValue)
// {
//     double[] res = new double[size];

//     var randon = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = Math.Round((randon.Next(minValue, maxValue ) + randon.NextDouble()),2); // 45 + 0.456854368
//     }
//     return res;
// }

// //Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// // которая покажет количество чётных чисел в массиве.


// int GetEvenCount(int[] array)
// {
//     int count = 0;
//     //[4,5,6,14]
//     foreach (int item in array)
//     {
//         if (item % 2 == 0) count++;
//     }
//     return count;
// }


// //Задайте одномерный массив, заполненный случайными числами. 
// //Найдите сумму элементов, стоящих на нечётных позициях.
// int GetSumOdd(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1) sum += array[i];
//     }

//     return sum;
// }

// //Задайте массив вещественных чисел. 
// //Найдите разницу между максимальным и минимальным элементов массива.
// double GetDifference(double[] array)
// {
//     double min = array[0];
//     double max = array[0];
//     foreach (var item in array)
//     {
//         if (min > item) min = item;
//         if (max < item) max = item;
//     }
//     return max - min;
// }

// // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// // Найдите сумму отрицательных и положительных элементов массива.
// //Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// // int[] array = GetArray(12, -9, 9);
// // Console.WriteLine(String.Join(" ", array));

// // int positiveSum = 0;
// // int negativeSum = 0;

// // foreach (int el in array)
// // {
// //     positiveSum += el > 0 ? el : 0;
// //     negativeSum += el < 0 ? el : 0;
// // }

// // Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");

// // int[] GetArray(int size, int minValue, int maxValue)
// // {
// //     int[] res = new int[size];

// //     for (int i = 0; i < size; i++)
// //     {
// //         res[i] = new Random().Next(minValue, maxValue + 1);
// //     }
// //     return res;
// // }

// /*Конец*/

// //Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// //[-4, -8, 8, 2] -> [4, 8, -8, -2] 


// // int[] startArray = GetArray(6, -10, 10);
// // Console.WriteLine(String.Join(" ", startArray));
// // Console.WriteLine(String.Join(" ", InversArray(startArray)));

// // int[] GetArray(int size, int minValue, int maxValue)
// // {
// //     int[] res = new int[size];


// //     for (int i = 0; i < size; i++)
// //     {
// //         res[i] = new Random().Next(minValue, maxValue + 1);
// //     }
// //     return res;
// // }

// int[] InversArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// /*Конец*/

// //Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, 3] -> да
// // Console.Write("Введите элементы массива через пробел: ");
// // string elements = Console.ReadLine();

// //  int[] baseArray = GetArrayFromString(elements);

// // Console.Write("Введите число: ");
// // int n = int.Parse(Console.ReadLine());

// // if (FindElement(baseArray, n))
// // {
// //     Console.WriteLine("Да");
// // }
// // else
// // {
// //     Console.WriteLine("Нет");
// // }


// int[] GetArrayFromString(string stringArray)
// {
//     //stringArray = "4 5 78 98 -5 56 0 num hello try "
//     //nums = {"4" "5" "78" "98" "-5" "56" "0" "num" "hello" "try"}
//     string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);

//     int[] res = new int[nums.Length];

//     for (int i = 0; i < nums.Length; i++)
//     {
//         int num = 10;
//         // "4"
//         // "num"
//         if (Int32.TryParse(nums[i], out num))
//         {
//             res[i] = num;

//         }
//         // out num = 10 
//     }

//     return res;
// }

// bool FindElement(int[] array, out int el)
// {
//     el += 15;
//     foreach (var item in array)
//     {
//         if (el == item) return true;
//     }
//     return false;
// }

// /*Конец*/

// // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // [5, 18, 123, 6, 2] -> 1
// // [1, 2, 3, 6, 2] -> 0
// // [10, 11, 12, 13, 14] -> 5

// // startArray = GetArray(123, 0, 1000);
// // Console.WriteLine($"Количество элементов в отрезке [10;99] = {GetCountElements(startArray, 10, 99)}");

// // int[] GetArray(int size, int minValue, int maxValue)
// // {
// //     int[] res = new int[size];

// //     for (int i = 0; i < size; i++)
// //     {
// //         res[i] = new Random().Next(minValue, maxValue + 1);
// //     }
// //     return res;
// // }

// int GetCountElements(int[] array, int leftRange, int rigthRange)
// {
//     int count = 0;
//     foreach (var item in array)
//     {
//         if (item >= leftRange && item <= rigthRange) count++;
//     }
//     return count;
// }

// /*Конец*/

// // Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21



// // int[] GetArrayFromString(string stringArray)
// // {
// //     string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// //     int[] res = new int[nums.Length];

// //     for (int i = 0; i < nums.Length; i++)
// //     {
// //         res[i] = int.Parse(nums[i]);
// //     }
// //     return res;
// // }

// int[] ResultArray(int[] array)
// {
//     int size = array.Length / 2;

//     if (array.Length % 2 == 1) size++;

//     int[] result = new int[size];

//     for (int i = 0; i < array.Length / 2; i++)
//     {

//         result[i] = array[i] * array[array.Length - 1 - i];
//     }

//     if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];

//     return result;
// }

// /*Конец*/

// Start();

// void Start()
// {
//     int rows = SetNumber("rows");
//     int columns = SetNumber("columns");

//     int[,] matrix = GetRandomMatrix(rows, columns, 10, 99);
//     PrintMatrix(matrix);
// }

// int SetNumber(string numberName)
// {
//     Console.Write($"Enter number {numberName}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int[,] GetRandomMatrix(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];

//     var rand = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = rand.Next(min, max + 1);
//         }
//     }

//     return array;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }

// }


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// Start();

// void Start()
// {
//     int rows = SetNumber("rows");
//     int columns = SetNumber("columns");

//     int[,] matrix = GetRandomMatrix(rows, columns, 10, 99);
//     PrintMatrix(matrix);
// }

// int SetNumber(string numberName)
// {
//     Console.Write($"Enter number {numberName}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int[,] GetRandomMatrix(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];

//     // var rand = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = i+j;
//         }
//     }

//     return array;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }

// }

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Start();

// void Start()
// {
//     int rows = SetNumber("rows");
//     int columns = SetNumber("columns");

//     int[,] matrix = GetRandomMatrix(rows, columns, 10, 99);
//     PrintMatrix(matrix);
//     ZamenArray(matrix);
//     System.Console.WriteLine();
//     PrintMatrix(matrix);
// }

// int SetNumber(string numberName)
// {
//     Console.Write($"Enter number {numberName}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int[,] GetRandomMatrix(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];

//     // var rand = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = i+j;
        
//         }
//     }

//     return array;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }

// }

// void ZamenArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i+=2)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j+=2)
//         {
//             matrix[i, j] = Convert.ToInt32(Math.Pow(matrix[i,j],2));
        
//         }
//     }

// }

// // Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Start();

// void Start()
// {
//     int rows = SetNumber("rows");
//     int columns = SetNumber("columns");

//     int[,] matrix = GetRandomMatrix(rows, columns, 10, 99);
//     PrintMatrix(matrix);
//     ZamenArray(matrix);
//     System.Console.WriteLine();
//     PrintMatrix(matrix);
//     SumElements(matrix);
//     System.Console.WriteLine(SumElements(matrix));
// }

// int SetNumber(string numberName)
// {
//     Console.Write($"Enter number {numberName}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int[,] GetRandomMatrix(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];

//     // var rand = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = i+j;
        
//         }
//     }

//     return array;
// }

// void PrintMatrix(int[,] matrix)
// {
    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }

// }

// int SumElements(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i==j) sum +=matrix[i,j];
//               }
//     }
//     return sum;
// }

// void ZamenArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i+=2)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j+=2)
//         {
//             matrix[i, j] = Convert.ToInt32(Math.Pow(matrix[i,j],2));
        
//         }
//     }

// }