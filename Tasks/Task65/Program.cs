// m - n

Console.WriteLine("Enter num M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter num N");
int numN = Convert.ToInt32(Console.ReadLine());

void NumsFromNtoM(int num1, int num2) 
{
    if(num1 > num2) 
    {
    Console.WriteLine($"{num1} ");
    NumsFromNtoM(num1 - 1, num2);
    }
    else if(num2 > num1)
    {
        NumsFromNtoM(num1, num2 - 1);
        Console.WriteLine($"{num2} ");
    }
    else
    {
        Console.WriteLine($"{num2} ");
    }
}
Console.WriteLine();
NumsFromNtoM(numM, numN);
