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

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)),2); 
// }

// Console.WriteLine("Inrut coordinate X to A:");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Inrut coordinate Y to A:");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Inrut coordinate Z to A:");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Inrut coordinate X to B:");
// double xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Inrut coordinate Y to B:");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Inrut coordinate Z to B:");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between point A with coordinates ({xa},{ya},{za}) and point B with coordinates ({xb},{yb},{zb}) -> {FindDistance(xa, ya, za, xb, yb, zb)}");