// 
Console.WriteLine("Enter number A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B");
int numberB = Convert.ToInt32(Console.ReadLine());

int method = Method(numberA, numberB);
Console.WriteLine(method);

int Method(int numA, int numB)
{   int res = 1;
    for (int i = 0; i < numB; i++)
    {
        res = res * numA;
    }
    return res;
}