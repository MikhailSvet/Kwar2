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

Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int k = a*a;
int k2 = b*b;

Console.WriteLine("да это квадрат первого числа");
Console.WriteLine(k);
Console.WriteLine("да это квадрат второго числа");
Console.WriteLine(k2);

