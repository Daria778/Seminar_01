// N!

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

int result = Factorial(number);
Console.WriteLine(result);

int Factorial(int num)
{
    int n = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            n = n * i;
        }
    }
    return n;
}