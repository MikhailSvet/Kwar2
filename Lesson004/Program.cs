//Возведите число А в натуральную степень B используя цикл

// Console.WriteLine("Введите число А");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В");
// int numB = Convert.ToInt32(Console.ReadLine());


// for (int ind = 0; ind <= numB; ind++)
// {
//     int result = numA * numA;

// }

// Console.WriteLine(result);
// int Number();
{
    Console.WriteLine("введите число а");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число В");
    int b = Convert.ToInt32(Console.ReadLine());
    int res = 1;
    
    for (int count = 1; count <= b; count++)
    {
        res = res * a;
    }
    Console.WriteLine(res);
    // return = res
}
// Console.WriteLine(number(c));