// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // m = 3, n = 4.

// // 0,5 7 -2 -0,2

// // 1 -3,3 8 -9,9

// // 8 7,8 -7,1 9


// // /*Конец*/

// Start();

// void Start()
// {
//     int rows = SetNumber("rows");
//     int columns = SetNumber("columns");

//     double[,] matrix = GetRandomMatrix(rows, columns, -1, 1);
//     PrintMatrix(matrix);
// }

// int SetNumber(string numberName)
// {
//     Console.Write($"Enter number {numberName}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// double[,] GetRandomMatrix(int rows, int columns, int min, int max)
// {
//     double[,] array = new double[rows, columns];

//     Random rand = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = rand.NextDouble() * (max-min);
//         }
//     }

//     return array;
// }

// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             // System.Console.Write($"{matrix[i, j]} ");
//             Console.Write("{0,6:F2}", matrix[i, j]);
//         }
//         System.Console.WriteLine();
//     }

// }



// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Start();

// void Start()
// {
//     int element = SetNumber("Element");
//     // int columns = SetNumber("columns");

//     int[,] matrix = GetRandomMatrix(3, 4, 10, 99);
//     PrintMatrix(matrix);
//     System.Console.WriteLine();
//     FindElements(matrix, element);
//     // System.Console.WriteLine(SumElements(matrix));
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

// int FindElements(int[,] matrix,int element)
// {
//     int elemetInMatrix = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j]==element)  
//             {
//                 elemetInMatrix+=1;
//                 System.Console.WriteLine($"Элумент есть в списке строка {i}, столбец {j}");
//             }
//               }
//     }
//     if (elemetInMatrix==0) System.Console.WriteLine($"Элемента {element} нет в списке");
//     if (elemetInMatrix>0) System.Console.WriteLine($"Всего найдено {elemetInMatrix} элементов в списке");
//     return elemetInMatrix;
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Start();

// void Start()
// {
//     // int element = SetNumber("Element");
//     // int columns = SetNumber("columns");

//     int[,] matrix = GetRandomMatrix(3, 5, 1, 5);
//     PrintMatrix(matrix);
//     System.Console.WriteLine();
//     FindMean(matrix);
//     // System.Console.WriteLine(SumElements(matrix));
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

// double FindMean(int[,] matrix)
// {
//     int sumALL=0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         double sum = 0;
        
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum += matrix[i, j];
        
//     }
//     double mean= sum / matrix.GetLength(0);
//     Console.Write("{0,6:F2}",mean);
// }
 
//    return sumALL;
// }

