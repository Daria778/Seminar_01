// 452 = 11, sum

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

int sum = Sum(number);
Console.WriteLine(sum);

int Sum(int num)
{
    int result = 0;
    while (num != 0)
    {
        int d = num % 10;
        result = result + d;
        num = num / 10;
    }
    return result;
}