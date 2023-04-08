// // Задача 24. Напишите программу, которая принимает 
// // на вход число (А) и выдает сумму числе от 1 до А.
// // 7-28, 4-10, 8-36

// int SetNumber(string text ="")
// {
//     Console.Write($"Enter number{text}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// int num =SetNumber();
// int sum =0;
// for(int i =1; i <= num;++i)
// {
//     sum +=i;
    
// }
// Console.WriteLine("sum =" + sum);

// // Задача 26: Напишите программу, которая принимает на вход
// // число и выдает количество цифр в числе.
// // 456-3, 78-2, 89126 -5

// int SetNumber(string text ="")
// {
//     Console.Write($"Enter number{text}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int MethodNum(int number)
// {
//     int count =0;
//     for(;number !=0; number/=10)
//     {
//          ++count;

//     }
//     return count;

// }


// int number =SetNumber();
// Console.WriteLine(MethodNum(number));


// // Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями
// //  и единицами в случайном порядке

// void methodArray(int[] array)
// {
//     int length  = array.Length;
//     Random rand = new Random();
//     for(int i=0;i<length; i++)
//     {
//         array[i] = rand.Next(2);
//     }
// }
// void print(int[] array)
// {
//     int length=array.Length;
//     for(int i=0;i<length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int[] array = new int[8];
// methodArray(array);
// print(array);



