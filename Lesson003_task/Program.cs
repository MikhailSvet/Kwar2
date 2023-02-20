


void CheckKoord(int x)
{
    if (x == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (x == 4)
        Console.WriteLine("x > 0, y < 0");
    else if (x == 3)
        Console.WriteLine("x < 0, y < 0");
    else if (x == 2)
        Console.WriteLine("x < 0, y > 0");
    else
        Console.WriteLine("Введены некорректные данные");
}

string CheckKoord2(int x)
{
    string res = "Были введены некорректные данные";
    if (x == 1)
        res = "x > 0, y > 0";
    else if (x == 4)
        res = "x > 0, y < 0";
    else if (x == 3)
        res = "x < 0, y < 0";
    else if (x == 2)
        res = "x < 0, y > 0";
    return res;
}

try
{
    Console.WriteLine("Введите координату Х");
    int x = Convert.ToInt32(Console.ReadLine());
    CheckKoord(x);
    Console.WriteLine(CheckKoord2(x));
}
catch
{
    Console.WriteLine("Были введены некорректные данные");
}
//  Напишите программу, которая принимает на вход координаты двух точек и находит
//  расстояние 
// между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21   

// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите координаты двух точек");
// int x =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты двух точек");
// int x =Convert.ToInt32(Console.ReadLine());
