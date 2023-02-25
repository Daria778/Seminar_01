// 
Console.WriteLine("Enter a number");
int numberA = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(numberA);
Console.WriteLine(result);

int SumNumbers(int numA)
{
    int sum = 0;
    for (int i = 1; i <= numA; i++)
    {
        checked
        {
            sum = sum + i;
        }
    }
    return sum;
}