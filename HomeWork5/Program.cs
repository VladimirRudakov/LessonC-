// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// //  Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// int[] FillArray (int length, int minValue, int maxValue)
// {
//     int [] result =new int[length];
//     Random rand = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         result[i] =rand.Next(minValue, maxValue +1);

//     }
//     return result;
// } 
// (int nonChetn, int positive) GetCount (int[] array)
// {
//     int nonChetn = 0;
//     int chetn =0;

//     for (int i =0; i < array.Length; i++)
//     {
//         if (array[i] %2 ==0)
//         {
//             chetn= chetn+1;
//         } 
//         else
//         {
//             nonChetn = nonChetn +1;

//         }
//     }
//     return (nonChetn, chetn);

// }

// int [] array = FillArray(4,100,999);
// (int nonChetn, int chetn) = GetCount(array);
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine($"Количество четных чисел в массиве ={chetn}");


// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// //  стоящих на нечётных позициях.

// // [3, 7, 23, 12] -> 19

// // [-4, -6, 89, 6] -> 0

// int[] FillArray (int length, int minValue, int maxValue)
// {
//     int [] result =new int[length];
//     Random rand = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         result[i] =rand.Next(minValue, maxValue +1);

//     }
//     return result;
// } 
// (int nonChetn, int positive) GetSum (int[] array)
// {
//     int nonChetn = 0;
//     int chetn =0;

//     for (int i =0; i < array.Length; i++)
//     {
//         if (array[i] %2 ==0)
//         {
//             chetn= chetn+1;
//         } 
//         else
//         {
//             nonChetn = nonChetn +array[i];

//         }
//     }
//     return (nonChetn, chetn);

// }

// int [] array = FillArray(4,0,99);
// (int nonChetn, int chetn) = GetSum(array);
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine($"сумму элементов стоящих на нечётных позициях массива ={ nonChetn}");




// // // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
// // //  минимальным элементов массива.

// // // [3 7 22 2 78] -> 76

// double [] FillArray (int length, double minValue, double maxValue)
// {
//     double[] result =new double[length];
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         result[i] =random.NextDouble() * (maxValue-minValue);
//         Console.Write("{0,6:F0}", result[i]);

//     }
//     return result;
// }
// double RasnMaxMin(double[] array)
// {
// double result = 0;
// double minValue =array[0];
// double maxValue =array[1];
// for(int i = 0; i < array.Length ; i++)
// {
    
//     if(array[i] < minValue)
//     {
//         minValue = array[i];
//     }
//     if(array[i] > maxValue)
//     {
//         maxValue = array[i];
//     }
// }
// double rasn =maxValue-minValue;
// return rasn;
// }


// double [] array = FillArray(4,0,99);
// double rasn = RasnMaxMin(array);

// Console.WriteLine("  Разница между максимальным и минимальным эдементом массива = ");
// Console.WriteLine("{0,6:F0}", rasn);

