// // Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// // на само себя).

// // Например:
// // 4 -> 16
// // -3 -> 9
// // -7 -> 49

// Console.WriteLine("Enter number : ");
// string strNum = Console.ReadLine();
// int num = Convert.ToInt32(strNum);

// int sqr = num * num;
// // double sqr = Math.Pow(num,2);

// Console.WriteLine($"sqr ={sqr}");

// int sqr = num * num;
// // double sqr = Math.Pow(num,2);

// Console.WriteLine($"sqr ={sqr}");


// // if(sqr < 0)
// // {
// //     sqr*=-1
// // }


// // Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// // a = 25, b = 5 -> да
// // a = 2, b = 10 -> нет
// // a = 9, b = -3 -> да
// // a = -3 b = 9 -> нет

// Console.WriteLine("Enter number in sqr : ");
// string strNum1 = Console.ReadLine();

// Console.WriteLine("Enter number without sqr : ");
// string strNum2 = Console.ReadLine();

// int num1 = Convert.ToInt32(strNum1);
// int num2 = Convert.ToInt32(strNum2);

// int num3 = num2 * num2;

// if (num1 == num3)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.Write("нет ");
    
// }

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Enter number : ");
string strNum1 = Console.ReadLine();

// Console.WriteLine("Enter number without sqr : ");
// string strNum2 = Console.ReadLine();

int num1 = Convert.ToInt32(strNum1);
// int num2 = Convert.ToInt32(strNum2);

// int num3 = num2 * num2;

if (num1 < 7)
{
    if (num1 == 1)
    {
        Console.Write("Понедельник");
    } 
    if (num1 == 2)
    {
        Console.WriteLine("вторник");
    } 
    if (num1 == 3)
    {
        Console.WriteLine("среда");
    } 
    if (num1 == 4)
    {
        Console.WriteLine("четверг");
    } 
    if (num1 == 5)
    {
        Console.WriteLine("пятница");
    } 
    if (num1 == 6)
    {
        Console.WriteLine("суббота");
    } 
    if (num1 == 7)
    {
        Console.WriteLine("восресенье");
    } 
    
}
else
{
    Console.Write("Нужен другой алгоритм ");
    
}