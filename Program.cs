// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// void Palindromic(int num)
// {
//     if(num >= 10000)
//     {
//         int num1 = num / 10000;
//         int num2 = num % 10;

//             if(num1 == num2)
//             {
//                 num = num / 10;
//                 int num3 = (num / 100) % 10;
//                 int num4 = num % 10;
//                 if(num3 == num4)
//                     Console.WriteLine("Да");
//             }
//             else 
//             Console.WriteLine("Нет");

//     }
//     else
//     Console.WriteLine("Некорректное число!");
// }

// Console.WriteLine("Введите пятизначное число:");
// int num = Convert.ToInt32(Console.ReadLine());
// Palindromic(num);