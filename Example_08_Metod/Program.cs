int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int b1 = 2888999;
int c1 = 67;
int d1 = 84;
int b2 = 233999;
int c2 = 33;
int d2 = 81;
int b3 = 20;
int c3 = 629998989;
int d3 = 89;



// int max1 = Max(b1,c1,d1);
// int max2 = Max(b2,c2,d2);
// int max3 = Max(b3,c3,d3);
// int max = Max(max1,max2,max3);
int max = Max(
    Max(b1, c1, d1)
    , Max(b2, c2, d2)
    , Max(b3, c3, d3));

// if (b1 > max) max = b1;
// if (c1 > max) max = c1;
// if (d2 > max) max = d2;

// if (b2 > max) max = b2;
// if (c2 > max) max = c2;
// if (d2 > max) max = d2;

// if (b3 > max) max = b3;
// if (c3 > max) max = c3;
// if (d3 > max) max = d3;


Console.Write("max = ");
Console.WriteLine(max);
