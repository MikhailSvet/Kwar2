//Console.WriteLine("Введите целое число");
/*int num = Convert.ToInt32(Console.ReadLine());
int y = num * num;
Console.WriteLine(y);

if (num>9)
{
    Console.WriteLine("Число больше 9");
}
else
{
    Console.WriteLine("Число меньше 9");
}
*/

/*Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int k = b*b;

if (a == k)
{
    Console.WriteLine("да это квадрат этого числа");

}
else
{
    Console.WriteLine ("Не квадрат числа");
}

/*Console.WriteLine("Введите первое число");
//int firstnum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondnum = Convert.ToInt32(Console.ReadLine());
if (firstnum == secondnum * secondnum)
	Console.WriteLine("Да");
else
Console.WriteLine("нет");
*/

/* Console.WriteLine("Введите номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num==1)
{
    Console.writeline("Понедельник");
}
if (num==2)
{
    Console.writeline("Вторник");
}
if (num==3)
{
    Console.writeline("Среда");
}
if (num==4)
{
    Console.writeline("Четверг");
}
if (num==5)
{
    Console.writeline("Пятница");
}
if (num==6)
{
    Console.writeline("Суббота");
}
if (num==7)
{
    Console.writeline("Воскресенье");
}
else
{
    Writeline("Ошибка. Попробуйте снова")
}
*/

/*
Console.WriteLine("Введите номер дня недели:");

int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
  case 1:
  Console.WriteLine("Понедельник");
  break;

  case 2:
  Console.WriteLine("Вторник");
  break;

  case 3:
  Console.WriteLine("Среда");
  break;

  case 4:
  Console.WriteLine("Четверг");
  break;

  case 5:
  Console.WriteLine("Пятница");
  break;

  case 6:
  Console.WriteLine("Суббота");
  break;

  case 7:
  Console.WriteLine("Воскресенье");
  break;

  default: 
  Console.WriteLine("Введён не тот номер недели.");
  break;
}
*/

//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//последнюю цифру этого числа.
//пример: 456 -> 6

// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//     int lastNumber = number % 10;
//     System.Console.WriteLine("Последнее число: " + lastNumber);
// }
// else
// {
//     System.Console.WriteLine("Неправильный номер: ");
// }

// Console.WriteLine("Введите два числа");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// int k = a*a;
// int k2 = b*b;

// Console.WriteLine("да это квадрат первого числа");
// Console.WriteLine(k);
// Console.WriteLine("да это квадрат второго числа");
// Console.WriteLine(k2);


// 12.02 
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
    
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

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

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456566 -> 46
// 782 -> 72
// 918 -> 98


int num = new Random().Next(99, 1000);
Console.WriteLine($"Было сгенерировано число {num}");
int num1 = num / 100;
int num2 = num % 10;
Console.WriteLine($"{num1}{num2}");



// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 % num1 == 0)
    Console.WriteLine("да,второе число кратно первому");
else
    Console.WriteLine("нет,второе число не кратно первому");

//     Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да