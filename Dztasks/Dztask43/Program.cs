// 

Console.WriteLine("Enter number k1");
double number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number b1");
double number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number k2");
double number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number b2");
double number4 = Convert.ToInt32(Console.ReadLine());

double y = Y(number1, number2, number3, number4);
double x = X(number1, number2, number3, number4);
Console.WriteLine($"({x}; {y})");


double X(double k1, double b1, double k2, double b2)
{
    double x = 0;
 x = (b2 - b1) /( k1 - k2);
return Math.Round(x, 2, MidpointRounding.ToZero);
}

double Y(double k1, double b1, double k2, double b2)
{
    double x = X( k1, b1, k2, b2);
    double y = k1 * x + b1;
    return Math.Round(y, 2, MidpointRounding.ToZero);
}