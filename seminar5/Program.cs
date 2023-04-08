// // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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
// (int negative, int positive) GetSum (int[] array)
// {
//     int negative = 0;
//     int positive =0;

//     for (int i =0; i < array.Length; i++)
//     {
//         if (array[i] >0)
//         {
//             positive += array[i];
//         } 
//         else
//         {
//             negative += array[i];

//         }
//     }
//     return (negative, positive);

// }

// int [] array = FillArray(12,-9,9);
// (int negative, int positive) = GetSum(array);
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine($"Сумма отрицательных чисел в массиве ={negative}, сумма положительных ={positive}");


// // ------ второй вариант этой задачи
// int size = 12;
// int[] nums = GetArray(size);
// Console.WriteLine(string.Join("; ", nums));

// int[] GetArray(int size)
// {
// int[] result = new int [size];
// Random rnd = new Random();
// for(int i = 0; i < size; i++)
// result[i] = rnd.Next(-9, 10);

// return result;
// }

// int SumNumPlus(int[] array)
// {
// int result = 0;
// for(int i = 0; i < size; i++)
// {
// if(array[i] > 0)
// {
// result = result + array[i];
// }
// }
// return result;
// }

// int SumNumMin(int[] array)
// {
// int result = 0;
// for(int i = 0; i < size; i++)
// {
// if(array[i] < 0)
// {
// result = result + array[i];
// }
// }
// return result;
// }

// Console.WriteLine($"Сумма положительных чисел: {SumNumPlus(nums)}");
// Console.WriteLine($"Сумма отрицательных чисел: {SumNumMin(nums)}");

// ______________________
// // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // [5, 18, 123, 6, 2] -> 1
// // [1, 2, 3, 6, 2] -> 0
// // [10, 11, 12, 13, 14] -> 5

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
// int GetCount (int[] array, int min, int max)
// {
//     int count = 0;
//     for (int i =0; i < array.Length; i++)
//     {
//         if (array[i] >= min && array[i]<= max)
//         {
//             Console.WriteLine($"Жопа ={count}");
//             count++;
//         } 

//     }
//     return count;

// }

// int [] array = FillArray(12,0,100);
// int count = GetCount(array, 10,99);
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine($"Количество чисел в заданном интервале ={count}");


//______________ Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] FillArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        result[i] = rand.Next(minValue, maxValue + 1);

    }
    return result;
}
int[] GetNewArray(int[] array)
{
    int size = array.Length % 2 == 0 ? array.Length / 2 : (array.Length / 2) + 1;
    int[] mult = new int[size];
    for (int i = 0; i < mult.Length; i++)
    {
        
        mult[i] = array[i] * array[array.Length - 1 - i];

    }
    if (array.Length % 2 == 1) mult[size-1] = array[array.Length / 2];
    return mult;

}

int[] array = FillArray(11, 0, 10);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", GetNewArray(array)));


