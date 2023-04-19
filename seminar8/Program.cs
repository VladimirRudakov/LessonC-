// // Решение задач в группах
// // Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами 
// // первую и последнюю строку массива.

// Start();

// void Start()
// {
//     // int element = SetNumber("Element");
//     // int columns = SetNumber("columns");

//     int[,] matrix = GetRandomMatrix(3, 3, 1, 3);
//     PrintMatrix(matrix);
//     System.Console.WriteLine();
//     ReverseRows(matrix);
//     PrintMatrix(matrix);
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

// void ReverseRows(int[,] matrix)
// {
//     int tmp;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         tmp = matrix[0,j];
//         matrix[0,j] =matrix[matrix.GetLength(0)-1,j];
//         matrix[matrix.GetLength(0) -1,j] = tmp;

//     }
    
// }
 

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки
//  на столбцы. В случае, если это невозможно, программа должна вывести сообщение
//   для пользователя.


// Start();

// void Start()
// {
//     // int element = SetNumber("Element");
//     // int columns = SetNumber("columns");

//     int[,] matrix = GetRandomMatrix(3, 4, 1, 5);
//     PrintMatrix(matrix);
//     System.Console.WriteLine();
//     matrix = ConvertToColumn(matrix);
//     PrintMatrix(matrix);
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

// int[,] ConvertToColumn(int[,] arr)
// {
//     int[,]arr2= new int[arr.GetLength(1), arr.GetLength(0)];
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         for (int j = 0; j < arr.GetLength(0); j++)
//         {
//             arr2[i,j] = arr[j,i];

//         }
//         }
//         return arr2;
        
//         }


// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь
//  содержит информацию о том, сколько раз встречается элемент входных данных. (НЕ ДОДЕЛАНА!!!!!)



Start();

void Start()
{
    int[,] matrix = GetRandomMatrix(3, 3, 1, 3);
    PrintMatrix(matrix);
    System.Console.WriteLine();
    PrintMatrix(matrix);
    System.Console.WriteLine();
    PrintResult(GetRowArray(matrix));
    

}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];

    var rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        
        }
    }

    return array;
}

void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }

}

int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0)*inArray.GetLength(1)];
    int index=0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i,j];
            index++;
            
        }
    }
    return result;
}


void PrintResult(int[] result)
{
    int length=result.Length;
    for(int i=0;i<length; i++)
    {
        Console.Write(result[i] + " ");
    }
}
