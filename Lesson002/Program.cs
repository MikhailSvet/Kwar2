﻿// 12.02 
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10,100);
// Console.WriteLine("Было сгенерировано "+num);
// Console.WriteLine($"Было сгенерировано число {num}");
// int x1 = num / 10;
// int x2 = num % 10;
// if (x1>x2)
//     Console.WriteLine(x1);
// else if (x1<x2)
//     Console.WriteLine(x2);
// else 
//     Console.WriteLine("обе цифры этого числа равны");
//     for (int i=0;i<=10;i++)
//     Console.Write($"{i} ");

// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 % num1 == 0)
//     Console.WriteLine("да,второе число кратно первому");
// else
//     Console.WriteLine("нет,второе число не кратно первому");


// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 % num1 == 0)
//     Console.WriteLine("да,второе число кратно первому");
// else
//     Console.WriteLine("нет,второе число не кратно первому");


//Напишите программу, которая выводит случайное трехзначное число и удаляет 
//вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100,1000);
// Console.WriteLine($"Было сгенерировано число {num}");
// int a = num % 10;
// int b = num / 100;
// b = b * 10;
// int c = a + b;
// Console.WriteLine(c);

// int num = new Random().Next(99, 1000);
// Console.WriteLine($"Было сгенерировано число {num}");
// int num1 = num / 100;
// int num2 = num % 10;
// Console.WriteLine($"{num1}{num2}");

//     Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет